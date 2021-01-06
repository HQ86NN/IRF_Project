using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace képernyőbillentyűzet
{
    class billentyű: Button
    {
        public static int méret = 25;
        public int sor, oszlop;

        public billentyű(int sor, int oszlop)
        {
            this.sor = sor;
            this.oszlop = oszlop;
            this.Top = sor * méret;
            this.Left = oszlop * méret;
            this.Height = méret;
            this.Width = méret;
        }

    }
}
