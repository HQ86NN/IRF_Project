using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace BeadandoProjekt_Akasztofa_HQ86NN
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

        string[] Betolt = File.ReadAllLines("feladvanyok.csv", Encoding.Default);

        public Form1()
        {
            InitializeComponent();
        }

        private void eredmenygomb_Click(object sender, EventArgs e)
        {
            try
            {

                xlApp = new Excel.Application();


                xlWB = xlApp.Workbooks.Add(Missing.Value);


                xlSheet = xlWB.ActiveSheet;

                xlSheet.Cells[1, 1] = "Játszott feladványok";
                xlSheet.Cells[1, 2] = "Hibaszám";
                xlSheet.Cells[1, 3] = "Nyert-e?";
                Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, 3));
                headerRange.Font.Bold = true;
                headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                headerRange.EntireColumn.AutoFit();
                


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
                }
                xlApp.Visible = true;
                xlApp.UserControl = true;

            }
            catch (Exception ex) 
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");
                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }

        }

        protected void MyButton_click(object sender, EventArgs e)
        {
            if (jatek.eredmeny == null)
            {
                Button b = sender as Button;
                jatek.TippProperty = Convert.ToChar(b.Text.ToLower());
                b.Visible = false;
                feladvany.Text = jatek.feladvany;
                uzenet.Text = jatek.uzenet;
                hibak.Text = jatek.hibaszam;
                if (jatek.eredmeny != null)
                {
                    eredmenyek.Add(jatek.eredmeny);
                }
            }
        }

        private void ujjatek_Click_1(object sender, EventArgs e)
        {
            string abc = "AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            Button[] Bill = new Button[35];
            for (int i = 0; i < 35; i++)
            {
                y = 200 + (i / 12) * 60;
                x = 5 + (i % 12) * 40;
                Bill[i] = new Button();
                Bill[i].Text = abc[i].ToString();
                Bill[i].Width = 40;
                Bill[i].Height = 40;
                Bill[i].Tag = i;
                Bill[i].Location = new Point(x, y);
                Bill[i].Click += new EventHandler(MyButton_click);
                Controls.Add(Bill[i]);
            }
            Invalidate();
            darab = Betolt.Count();
            db = n.Next(0, darab);
            jatek = new Jatek(Betolt[db]);
            feladvany.Text = jatek.csillag;
            uzenet.Text = "";
            hibak.Text = "";
        }
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }






    }
}
