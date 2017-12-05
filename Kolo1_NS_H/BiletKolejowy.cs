using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_H
{
    class BiletKolejowy:Bilet
    {
        private string klasa;

        public BiletKolejowy(double p1, bool p2, string p3)
            : base(p1, p2)
        {
            this.klasa = p3;
        }

        public int CzasPodrozy(int p1)
        {
            return p1 / 900;
        }
    }
}
