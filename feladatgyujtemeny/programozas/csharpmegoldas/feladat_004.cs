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
            // Írj programot, ami beolvas két számot, majd kiírja:
            // a. az összegüket;
            // b. különbségüket;
            // c. szorzatukat;
            // d. hányadosukat, ha lehet (két tizedesjegyre kerekítve)!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int elsoAdat = 0;
            int masodikAdat = 0;
            int osszeg = 0;
            int kulonbseg = 0;
            int szorzat = 0;
            double hanyados = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérek egy pozitív egész számot: ");
            elsoAdat = Int32.Parse(Console.ReadLine());
            Console.Write("Kérek egy másik pozitív egész számot (!= 0): ");
            masodikAdat = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            osszeg = elsoAdat + masodikAdat;
            kulonbseg = elsoAdat - masodikAdat;
            szorzat = elsoAdat * masodikAdat;
            hanyados = (double) elsoAdat / masodikAdat;

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A két szám: {elsoAdat}, {masodikAdat}";
            kimenet += $"\nÖsszege: {osszeg}";
            kimenet += $"\nKülönbsége: {kulonbseg}";
            kimenet += $"\nSzorzata: {szorzat}";
            kimenet += $"\nHányadosa: {hanyados:F2}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
