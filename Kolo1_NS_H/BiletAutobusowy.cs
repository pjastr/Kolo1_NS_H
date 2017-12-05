using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_H
{
    class BiletAutobusowy:Bilet
    {
        private int numer;

        public BiletAutobusowy(double p1, bool p2, int p3)
            : base(p1, p2)
        {
            this.numer = p3;
        }

        public bool Kontrola()
        {
            if (numer >= 10 && numer <= 99)
            {
                return true;
            }
            else return false;
        }
    }
}
