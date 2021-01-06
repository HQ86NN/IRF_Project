using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;

namespace akasztófa
{
    public partial class Form1 : Form
    {

        int x, y, darab;

        Akasztofa akaszto = new Akasztofa();
        Jatek jatek;

        int db;
        Random n = new Random();
        List<Eredmeny> eredmenyek = new List<Eredmeny>();

        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            if (jatek != null)
            {
                akaszto.rajzol(g, jatek.hibapont);
            }



        }

        string[] fajlbol = File.ReadAllLines("feladvanyok.csv", Encoding.Default);
        public Form1()
        {
            InitializeComponent();
        }
        protected void MyButton_click(object sender, EventArgs e)
        {
            if (jatek.eredmeny == null)
            {
                Button b = sender as Button;
                jatek.tippProperty = Convert.ToChar(b.Text.ToLower());
                b.Visible = false;
                feladvany.Text = jatek.feladvany;
                uzenet.Text = jatek.uzenet;
                hibaszam.Text = jatek.hibaszam;
                if (jatek.eredmeny != null)
                {
                    eredmenyek.Add(jatek.eredmeny);
                }
            }

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            string abc = "AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            Button[] Gombok = new Button[35];
            for (int i = 0; i < 35; i++)
            {
                Gombok[i] = new Button();
                Gombok[i].Text = abc[i].ToString();
                y = 200 + (i / 12) * 60;
                Gombok[i].Width = 40;
                Gombok[i].Height = 40;
                Gombok[i].Tag = i;
                x = 5 + (i % 12) * 40;
                Gombok[i].Location = new Point(x, y);
                Gombok[i].Click += new EventHandler(MyButton_click);
                Controls.Add(Gombok[i]);

            }
            Invalidate();
            darab = fajlbol.Count();
            db = n.Next(0, darab);
            jatek = new Jatek(fajlbol[db]);



            feladvany.Text = jatek.közbülső;
            uzenet.Text = "";
            hibaszam.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                xlApp = new Excel.Application();


                xlWB = xlApp.Workbooks.Add(Missing.Value);


                xlSheet = xlWB.ActiveSheet;

                xlSheet.Cells[1, 1] = "Feladvány";
                xlSheet.Cells[1, 2] = "Hibaszám";
                xlSheet.Cells[1, 3] = "Nyert-e?";

                for (int i = 0; i < eredmenyek.Count; i++)
                {
                    xlSheet.Cells[i + 2, 1] = eredmenyek[i].feladvany;
                    xlSheet.Cells[i + 2, 2] = eredmenyek[i].hibaszam;
                    if (eredmenyek[i].nyert)
                    {
                        xlSheet.Cells[i + 2, 3] = "igen";
                    }
                    else
                    {
                        xlSheet.Cells[i + 2, 3] = "nem";
                    }
                    // xlSheet.Cells[i, 3] = eredmenyek[i].nyert ? "a" : "b";
                }

                // Control átadása a felhasználónak
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex) // Hibakezelés a beépített hibaüzenettel
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                // Hiba esetén az Excel applikáció bezárása automatikusan
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }
        }




    }

}
