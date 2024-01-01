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
            // Írj programot, ami beolvassa a felhasználó nevét, majd köszön neki!

            // Adatszerkezet (Data Structure)
            // (Globális) Változók deklarálása (és ha lehet definiálása)
            string nev = "";
            string udvozlet = "";

            // Felhasználói felület (User Interface) - bekérés
            Console.Write("Kérem a nevedet: ");
            nev = Console.ReadLine();
            
            // Üzleti logika (Business Logic)

            // Felhasználói felület (User Interface) - kiíratás
            udvozlet = $"Hello {nev}!";
            Console.WriteLine(udvozlet);

            Console.ReadKey(true);
        }
    }
}
