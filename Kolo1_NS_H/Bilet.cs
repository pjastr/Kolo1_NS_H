using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_H
{
    class Bilet
    {
        protected double cena;
        protected bool ulga;

        public Bilet(double p1, bool p2)
        {
            this.cena = p1;
            this.ulga = p2;
        }

        public void Pokaz()
        {
            Console.WriteLine(cena + " " + ulga);
        }
    }
}
