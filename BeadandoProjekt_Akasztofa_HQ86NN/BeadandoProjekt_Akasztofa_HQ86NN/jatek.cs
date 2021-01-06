using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoProjekt_Akasztofa_HQ86NN
{
    class Jatek
    {
        public string csillag = "", hibaszam = "", feladvany = "", uzenet = "";
        string kitalalando, seged = "";
        public int hibapont = 0;


        public Jatek(string kitalalando)
        {
            this.kitalalando = kitalalando;
            this.csillag = csillag.PadRight(kitalalando.Length, '*');
        }
        private char tipp;

        public char TippProperty
        {
            get { return tipp; }
            set
            {
                tipp = value;
                Ellenoriz();
            }
        }


        void Ellenoriz()
        { 
            for (int i = 0; i < kitalalando.Length; i++)
            {
                if (tipp == kitalalando[i]) { seged += tipp; }
                else { seged += csillag[i]; }
            }
            if (csillag == seged) hibapont++;

            csillag = seged;
            hibaszam = Convert.ToString(hibapont);
            feladvany = csillag;
            if ((kitalalando == csillag) && (hibapont < 9))
            {
                feladvany = "";
                uzenet = "Gratulálok nyert! A megoldás:" + kitalalando;
            }
            if (hibapont >= 9)
            {
                uzenet = "vesztett! a megoldás:" + kitalalando;
            }

        }
    }
}
