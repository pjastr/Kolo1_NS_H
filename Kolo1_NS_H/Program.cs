using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolo1_NS_H
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilet b1 = new Bilet(5.2, true);
            Bilet b2 = new Bilet(3.2, false);
            BiletAutobusowy a1 = new BiletAutobusowy(3, true, 5);
            BiletAutobusowy a2 = new BiletAutobusowy(34, false, 123);
            BiletKolejowy k1 = new BiletKolejowy(4.5, true, "3334f");
            BiletKolejowy k2 = new BiletKolejowy(1.5, false, "ujbf");
            a1.Kontrola();
            a2.Kontrola();
            k1.CzasPodrozy(5344);
            k2.CzasPodrozy(732);
            b1.Pokaz();
            b2.Pokaz();
            a1.Pokaz();
            a2.Pokaz();
            k1.Pokaz();
            k2.Pokaz();

            Console.ReadKey();
        }
    }
}
