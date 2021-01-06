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

namespace BeadandoProjekt_Akasztofa_HQ86NN
{
    public partial class Form1 : Form
    {
        int x, y, darab;
        Akasztofa akaszto = new Akasztofa();
        Jatek jatek;
        int db;
        Random n = new Random();
        
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
        protected void MyButton_click(object sender, EventArgs e)
        {

            Button b = sender as Button;
            jatek.TippProperty = Convert.ToChar(b.Text.ToLower());
            b.Visible = false;
            feladvany.Text = jatek.feladvany;
            uzenet.Text = jatek.uzenet;
            hibak.Text = jatek.hibaszam;
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

        

        
        


    }
}
