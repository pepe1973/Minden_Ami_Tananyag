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
            // Írj programot, ami beolvassa a háromszög oldalainak hosszát, és megmondja, hogy
            // ilyen oldalakkal szerkeszthető - e háromszög!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int elsoAdat = 0;
            int masodikAdat = 0;
            int harmadikAdat = 0;
            bool logika = false;
            bool szerkesztheto = false;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az első oldalt: ");
            elsoAdat = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második oldalt: ");
            masodikAdat = Int32.Parse(Console.ReadLine()); 
            Console.Write("Kérem a harmadik oldalt: ");
            harmadikAdat = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            logika = elsoAdat < masodikAdat + harmadikAdat && masodikAdat < elsoAdat + harmadikAdat && harmadikAdat < elsoAdat + masodikAdat; 
            
            if (logika)
            {
                szerkesztheto = true;
            }

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"Az adatokból: {elsoAdat}, {masodikAdat} és {harmadikAdat}: háromszög szerkeszthető: {szerkesztheto}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
