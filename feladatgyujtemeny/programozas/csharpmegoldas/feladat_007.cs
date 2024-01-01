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
            // Írj programot, mely beolvas két pozitív egész számot, és kiírja a számtani és
            // mértani közepüket! A gyökvonáshoz használd a Math.Sqrt() függvényt!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int elsoAdat = 0;
            int masodikAdat = 0;
            double szamtaniKozep = 0.0d;
            double mertaniKozep = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az első pozitív egész számot: ");
            elsoAdat = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a második pozitív egész számot: ");
            masodikAdat = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            szamtaniKozep = ((double)elsoAdat + (double)masodikAdat) / 2;
            mertaniKozep = Math.Sqrt(elsoAdat * masodikAdat);

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"Az adatok: {elsoAdat}, {masodikAdat}";
            kimenet += $"\nSzámtani közép: {szamtaniKozep}";
            kimenet += $"\nMértani közép: {mertaniKozep}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
