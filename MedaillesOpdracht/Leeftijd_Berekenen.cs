using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Leeftijd_Berekenen
    {
        public void Start()
        {
            Console.WriteLine("\nHallo! Wat is jouw geboortedatum?");
            Console.WriteLine("Kies eerst een jaartal.");
            int keuzeJaartal = Convert.ToInt32(Console.ReadLine());
            int Jaartal = DateTime.Now.Year - keuzeJaartal;
            if (keuzeJaartal > 2026)
            {
                Console.WriteLine("\nOngeldige antwoord. Het is nog 2025!");
            } else if (keuzeJaartal >= 1900 && keuzeJaartal < 2026)
            {
                Console.WriteLine("\nKies nu jouw geboortemaand.");
                string keuzeMaand = Console.ReadLine().ToLower();
                if (keuzeMaand == "januari" || keuzeMaand == "februari" ||
                    keuzeMaand == "maart" || keuzeMaand == "april" ||
                    keuzeMaand == "mei" || keuzeMaand == "juni" ||
                    keuzeMaand == "juli" || keuzeMaand == "augustus" ||
                    keuzeMaand == "september" || keuzeMaand == "oktober" ||
                    keuzeMaand == "november" || keuzeMaand == "december")
                {
                    Console.WriteLine("\nKies als laatste jouw geboortedag.");
                    int keuzeDag = Convert.ToInt32(Console.ReadLine());
                    if (keuzeDag > 0 && keuzeDag <= 31)
                    {
                        Console.WriteLine("\nJe bent geboren in " + keuzeDag + " " + keuzeMaand + " " + keuzeJaartal + "!");
                        Console.WriteLine("Je bent dus " + Jaartal + " jaar oud!");
                    } else
                    {
                        Console.WriteLine("\nOngeldige antwoord.");
                    }
                } else
                {
                    Console.WriteLine("\nOngeldige antwoord.");
                }
            } else
            {
                Console.WriteLine("\nOngeldige antwoord.");
            } if (Jaartal >= 18)
            {
                Console.WriteLine("Je hebt de recht om te kunnen stemmen omdat je minimaal 18 jaar oud bent!");
            } else
            {
                Console.WriteLine("Omdat je jonger dan 18 bent, heb je nog niet de recht om te kunnen stemmen.");
            }
        }
    }
}