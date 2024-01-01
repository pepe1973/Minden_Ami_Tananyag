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
            // Írj programot, mely beolvas három egész számot, és kiírja a képernyőre a
            // legkisebbet!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int elsoSzam = 0;
            int masodikSzam = 0;
            int harmadikSzam = 0;
            int legkisebb = 0;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az első számot: ");
            elsoSzam = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második számot: ");
            masodikSzam = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a harmadik számot: ");
            harmadikSzam = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            if (elsoSzam <= masodikSzam)
            {
                if (elsoSzam <= harmadikSzam)
                {
                    legkisebb = elsoSzam;
                }
                else
                {
                    legkisebb = harmadikSzam;
                }
            }
            else
            {
                if (masodikSzam <= harmadikSzam)
                {
                    legkisebb = masodikSzam;
                }
                else
                {
                    legkisebb = harmadikSzam;
                }
            }

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A számok: {elsoSzam}, {masodikSzam}, {harmadikSzam}. ";
            kimenet += $"Legkisebb szám: {legkisebb}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
