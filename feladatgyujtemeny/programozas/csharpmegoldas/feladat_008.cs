using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Feladatgyujtemeny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Írj programot, mely beolvassa a másodfokú egyenlet együtthatóit, és kiírja, hogy az
            // egyenletnek van-e megoldása!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int aEgyutt = 0;
            int bEgyutt = 0;
            int cEgyutt = 0;
            double diszkriminans = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az első együtthatót: ");
            aEgyutt = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második együtthatót: ");
            bEgyutt = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik együtthatót: ");
            cEgyutt = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            diszkriminans = Math.Pow(bEgyutt, 2) - 4 * aEgyutt * cEgyutt;
            if (diszkriminans < 0) 
            {
                kimenet = "Nincs valós megoldás.";
            }
            else
            {
                kimenet = "Van valós megoldás.";
            }

            // Felhasználói felület (User Interface) - kiíratás
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
