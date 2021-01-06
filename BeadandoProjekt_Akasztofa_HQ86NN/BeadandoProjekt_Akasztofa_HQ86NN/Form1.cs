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
        int y, x, darab;
        Jatek jatek;
        int db;
        Random n = new Random();
        string[] betolt = File.ReadAllLines("feladvanyok.csv", Encoding.Default);
        public Form1()
        {
            InitializeComponent();
        }

        private void ujjatek_Click(object sender, EventArgs e)
        {
            string abc = "AÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ";
            Button[] Billentyuk = new Button[35];
            for (int i = 0; i < 35; i++)
            {
                Billentyuk[i] = new Button();
                Billentyuk[i].Text = abc[i].ToString();
                y = 300 + (i / 12) * 40;
                Billentyuk[i].Width = 35;
                Billentyuk[i].Height = 35;
                Billentyuk[i].Tag = i;
                x = 5 + (i % 12) * 40;
                Billentyuk[i].Location = new Point(x, y);
                Billentyuk[i].Click += new EventHandler(gombok);
                Controls.Add(Billentyuk[i]);

            }
            Invalidate();
            darab = betolt.Count();
            db = n.Next(0, darab);
            jatek = new Jatek(betolt[db]);
            feladvany.Text = jatek.csillag;
            //uzenet.Text = "";
            hibak.Text = "";

        }
        protected void gombok(object sender, EventArgs e)
        {
           
                Button b = sender as Button;
                jatek.TippProperty = Convert.ToChar(b.Text.ToLower());
                b.Visible = false;
                feladvany.Text = jatek.feladvany;
                hibak.Text = jatek.hibaszam;
               
            

        }


    }
}
