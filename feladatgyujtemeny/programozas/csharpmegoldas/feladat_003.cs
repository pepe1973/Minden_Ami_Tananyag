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
            // Írj programot, ami beolvas egy számot, majd kiírja a kétszeresét!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int adat = 0;
            int duplaAdat = 0;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérek egy egész számot: ");
            adat = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            duplaAdat = 2 * adat;

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A szám: {adat} kétszerese: {duplaAdat}.";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
