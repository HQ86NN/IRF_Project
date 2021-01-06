using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akasztófa
{
    class Akasztofa
    {
        readonly Pen toll = new Pen(Color.Blue, 5);

        public void rajzol(Graphics g, int hibapont)
        {

            switch (hibapont)
            {
                case 1:
                    Oszlop(g);
                    break;
                case 2:
                    Teto(g);
                    break;
                case 3:
                    Kotel(g);
                    break;
                case 4:
                    Fej(g);
                    break;
                case 5:
                    Torzs(g);
                    break;
                case 6:
                    Balkez(g);
                    break;
                case 7:
                    Jobbkez(g);
                    break;
                case 8:
                    Ballab(g);
                    break;
                case 9:
                    Jobblab(g);
                    break;
            }
        }

        private void Jobblab(Graphics g)
        {
            g.DrawLine(toll, 750, 300, 800, 400);
        }

        private void Ballab(Graphics g)
        {
            g.DrawLine(toll, 700, 400, 750, 300);
        }

        private void Jobbkez(Graphics g)
        {
            g.DrawLine(toll, 750, 200, 800, 200);
        }

        private void Balkez(Graphics g)
        {
            g.DrawLine(toll, 700, 200, 750, 200);
        }

        private void Torzs(Graphics g)
        {
            g.DrawLine(toll, 750, 190, 750, 300);
        }

        private void Fej(Graphics g)
        {
            g.DrawEllipse(toll, 730, 150, 40, 40);
        }

        private void Kotel(Graphics g)
        {
            g.DrawLine(toll, 750, 100, 750, 150);
        }

        private void Teto(Graphics g)
        {
            g.DrawLine(toll, 600, 100, 750, 100);
        }

        private void Oszlop(Graphics g)
        {
            g.DrawLine(toll, 600, 100, 600, 500);
        }


    }
}




