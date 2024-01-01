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
            // Írj programot, ami beolvassa a körív sugarát és középponti szögét, és kiírja a körív
            // területét és a határoló ív hosszát!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int sugar = 0;
            int kozpontiSzog = 0;
            double pi = Math.PI;
            double ivHossz = 0.0d;
            double korivTerulet = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem a körív sugarát: ");
            sugar = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a körív középponti szögét: ");
            kozpontiSzog = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            ivHossz = (sugar * pi * kozpontiSzog) / 180;
            korivTerulet = (sugar * ivHossz) / 2;

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A körív sugara: {sugar} és központi szöge: {kozpontiSzog}.";
            kimenet += $"\nÍvhossza: {ivHossz}";
            kimenet += $"\nTerülete: {korivTerulet}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
