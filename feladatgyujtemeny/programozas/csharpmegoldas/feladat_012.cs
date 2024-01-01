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
            // Írj programot, mely beolvassa egy kör átmérőjét, és kiírja a kör kerületét és
            // területét! A pi értékének meghatározásához használd a Math.PI értéket!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int sugar = 0;
            double pi = Math.PI;
            double kerulet = 0.0d;
            double terulet = 0.0d;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem a kör sugarát: ");
            sugar = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            kerulet = 2 * sugar * pi;
            terulet = Math.Pow(sugar, 2) * pi;

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A kör sugara: {sugar}";
            kimenet += $"\nKerület: {kerulet}";
            kimenet += $"\nTerület: {terulet}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
