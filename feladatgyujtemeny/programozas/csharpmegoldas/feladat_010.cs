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
            // Írj programot, mely beolvassa egy derékszögű háromszög két befogóját, és megadja
            // az átfogójának a hosszát!Az átfogót 2 tizedesjeggyel add meg!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int aBefogo = 0;
            int bBefogo = 0;
            double cAtfogo = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az a-befogót: ");
            aBefogo = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a b-befogót: ");
            bBefogo = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            cAtfogo = Math.Sqrt(Math.Pow(aBefogo, 2) + Math.Pow(bBefogo, 2));

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A befogók: {aBefogo}, {bBefogo}, átfogó: {cAtfogo}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
