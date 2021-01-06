using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeadandoProjekt_Akasztofa_HQ86NN
{
    class GombTulajdonsagok : Button
    {
        public int sor, oszlop, magassag, szelesseg;
        public string karakter;
        GombTulajdonsagok[] gombok = new GombTulajdonsagok[47];

        GombTulajdonsagok tulajdonsag = new GombTulajdonsagok();
        gombok[i] = tulajdonsag;

        tulajdonsag.sor = Convert.ToInt32(sr.ReadLine());
    }

    

}
