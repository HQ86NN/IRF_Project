using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeadandoProjekt_Akasztofa_HQ86NN
{
    class Eredmeny
    {
        public string feladvany;
        public string hibaszam;
        public bool nyert;
        public Eredmeny(string feladvany, string hibaszam, bool nyert)
        {
            this.feladvany = feladvany;
            this.hibaszam = hibaszam;
            this.nyert = nyert;
        }
    }
}
