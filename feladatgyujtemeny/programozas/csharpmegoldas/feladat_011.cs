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
            // Írj programot, mely beolvassa a téglatest három élének hosszát, és kiírja a
            // felszínének és térfogatának mérőszámát!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók - deklarálása (és ha lehet definiálása)
            int aOldal = 0;
            int bOldal = 0;
            int cOldal = 0;
            int felszin = 0;
            int terfogat = 0;
            string kimenet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem az a-oldalt: ");
            aOldal = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a b-oldalt: ");
            bOldal = Int32.Parse(Console.ReadLine());
            Console.Write("Kérem a c-oldalt: ");
            cOldal = Int32.Parse(Console.ReadLine());

            // Üzleti logika (Business Logic)
            felszin = 2 * (aOldal * bOldal + aOldal * cOldal + bOldal * cOldal);
            terfogat = aOldal * bOldal * cOldal;

            // Felhasználói felület (User Interface) - kiíratás
            kimenet = $"A téglatest oldalai: {aOldal}, {bOldal}, {cOldal}";
            kimenet += $"\nFelszín: {felszin}";
            kimenet += $"\nTérfogat: {terfogat}";
            Console.WriteLine(kimenet);

            Console.ReadKey(true);
        }
    }
}
