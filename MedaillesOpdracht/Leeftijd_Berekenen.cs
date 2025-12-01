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
            } if (Jaartal >= 18 && Jaartal <= 24)
            {
                Console.WriteLine("\nJe hebt de recht om te kunnen stemmen omdat je minimaal 18 jaar oud bent!");
            }
            else if (Jaartal >= 25 && Jaartal <= 64)
            {
                Console.WriteLine("\nJe bent toegestaan om iemand trouwen omdat je minimaal 25 jaar oud bent!");
            }
            else if (Jaartal >= 65 && Jaartal <= 66)
            {
                Console.WriteLine("\nJe bent een bejaarde, maar moet nog steeds werken. Hou zo vol!");
            }
            else if (Jaartal >= 67)
            {
                Console.WriteLine("\nJe bent een bejaarde en kan gerust van het leven genieten zonder werk!");
            } else if (Jaartal < 18)
            {
                Console.WriteLine("\nOmdat je jonger dan 18 bent, heb je nog niet de recht om te kunnen stemmen.");
            }
        }
    }
}