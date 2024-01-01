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
            // Írj programot, mely beolvas két egész számot, és kiírja a képernyőre a nagyobbikat!
            
            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int elsoAdat = 0;
            int masodikAdat = 0;
            int nagyobb = 0;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérek egy egész számot: ");
            elsoAdat = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy másik egész számot: ");
            masodikAdat = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            if (elsoAdat < masodikAdat)
            {
                nagyobb = masodikAdat;
            } else
            {
                nagyobb = elsoAdat;
            }

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A két szám: {elsoAdat}, {masodikAdat} közül a nagyobb: {nagyobb}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
