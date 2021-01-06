using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akasztófa
{
    class Jatek
    {

        public string közbülső = "", hibaszam = "", feladvany = "", uzenet = "";
        string kitalálandó, seged = "";
        int tippekszama = 0;
        public int hibapont = 0;
        public Eredmeny eredmeny;

        public Jatek(string kitalalando)
        {
            this.kitalálandó = kitalalando;
            this.közbülső = közbülső.PadRight(kitalálandó.Length, '*');
        }
        private char tipp;

        public char tippProperty
        {
            get { return tipp; }
            set
            {
                tipp = value;
                ellenoriz();
            }
        }


        void ellenoriz()
        {
            tippekszama++;
            seged = "";
            for (int i = 0; i < kitalálandó.Length; i++)
            {
                if (tipp == kitalálandó[i]) { seged += tipp; }
                else { seged += közbülső[i]; }
            }
            if (közbülső == seged) hibapont++;

            közbülső = seged;
            hibaszam = Convert.ToString(hibapont);
            feladvany = közbülső;
            if ((kitalálandó == közbülső) && (hibapont < 9))
            {
                feladvany = "";
                uzenet = "Gratulálok nyert! A megoldás:" + kitalálandó;
                eredmeny = new Eredmeny(kitalálandó, hibaszam, true);
            }
            if (hibapont >= 9)
            {
                uzenet = "vesztett! a megoldás:" + kitalálandó;
                eredmeny = new Eredmeny(kitalálandó, hibaszam, false);

            }

        }
    }
}
