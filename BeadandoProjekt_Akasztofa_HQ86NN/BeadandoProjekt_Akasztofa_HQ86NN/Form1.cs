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
        public Form1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("kbd_hun.txt", Encoding.Default);
            int[] oszlop = new int[47];
            int[] sor = new int[47];
            int[] magasság = new int[47];
            int[] szélesség = new int[47];
            string[] karakter = new string[47];

            for (int i = 0; i < 47; i++)
            {
                oszlop[i] = Convert.ToInt32(sr.ReadLine());
                sor[i] = Convert.ToInt32(sr.ReadLine());
                magasság[i] = Convert.ToInt32(sr.ReadLine());
                szélesség[i] = Convert.ToInt32(sr.ReadLine());
                karakter[i] = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(Convert.ToString(karakter[46]));
        }
    }
}
