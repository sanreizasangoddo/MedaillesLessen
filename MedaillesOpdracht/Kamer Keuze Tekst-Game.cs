using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Kamer_Keuze_Tekst_Game
    {
        public void Start()
        {
            string huidigeLocatie = "Keuken";
            bool spelActief = true;

            while (spelActief)
            {

                if (huidigeLocatie == "Keuken")
                {
                    Console.WriteLine("\nJe staat in de keuken. Er is een deur naar de 'gang', een deur naar de 'tuin', en een 'kast'.");
                    Console.WriteLine("Wat doe je? (Typ 'gang', 'tuin' of 'kast')");
                    string keuzeKeuken = Console.ReadLine().ToLower();

                    if (keuzeKeuken == "gang")
                    {
                        huidigeLocatie = "Gang";
                    }
                    else if (keuzeKeuken == "tuin")
                    {
                        huidigeLocatie = "Tuin";
                    }
                    else if (keuzeKeuken == "kast")
                    {
                     Console.WriteLine("\nJe opent de kast en vindt een oude map! (Hint: Keuken -> Gang -> Wc)");
                     
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                else if (huidigeLocatie == "Gang")
                {
                    Console.WriteLine("\nJe staat in de gang. Er is een deur naar de 'keuken', een deur naar de 'woonkamer', en een deur naar de 'wc'.");
                    Console.WriteLine("Wat doe je? (Typ 'keuken', 'woonkamer' of 'wc')");
                    string keuzeGang = Console.ReadLine().ToLower();

                    if (keuzeGang == "keuken")
                    {
                        huidigeLocatie = "Keuken";
                    }
                    else if (keuzeGang == "woonkamer")
                    {
                        huidigeLocatie = "Woonkamer";
                    }
                    else if (keuzeGang == "wc")
                    {
                        huidigeLocatie = "Wc";
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                else if (huidigeLocatie == "Woonkamer")
                {
                    Console.WriteLine("\nJe staat in de woonkamer. Er is een deur naar de 'gang', een deur naar de 'balkon', en een 'tafel'.");
                    Console.WriteLine("Wat doe je? (Typ 'gang', 'balkon' of 'tafel')");
                    string keuzeWoonkamer = Console.ReadLine().ToLower();

                    if (keuzeWoonkamer == "gang")
                    {
                        huidigeLocatie = "Gang";
                    }
                    else if (keuzeWoonkamer == "balkon")
                    {
                        huidigeLocatie = "Balkon";
                    }
                    else if (keuzeWoonkamer == "tafel")
                    {
                        Console.WriteLine("\nJe bekijkt de tafel en ziet een briefje: 'Zoek de schat in de tuin!'");
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                else if (huidigeLocatie == "Wc")
                {
                    Console.WriteLine("\nJe staat in de wc. Er is een deur naar de 'gang'.");
                    Console.WriteLine("Wat doe je? (typ 'gang')");
                    string keuzeWC = Console.ReadLine().ToLower();

                    if (keuzeWC == "gang")
                    {
                        huidigeLocatie = "Gang";
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                else if (huidigeLocatie == "Tuin")
                {
                    Console.WriteLine("\nJe staat in de tuin. Er is een deur naar de 'keuken', en een 'vijver'.");
                    Console.WriteLine("Wat doe je? (typ 'keuken' of 'vijver')");
                    string keuzeTuin = Console.ReadLine().ToLower();

                    if (keuzeTuin == "keuken")
                    {
                        huidigeLocatie = "Keuken";
                    }
                    else if (keuzeTuin == "vijver")
                    {
                        Console.WriteLine("\nJe kijkt in de vijver en ziet een schat! Gefeliciteerd! Je hebt gewonnen!");
                        spelActief = false;
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                else if (huidigeLocatie == "Balkon")
                {
                    Console.WriteLine("\nJe staat op het balkon. Je ziet de zon schijnen. Er is een deur naar de 'woonkamer'.");
                    Console.WriteLine("Wat doe je? (Typ 'woonkamer')");
                    string keuzeBalkon = Console.ReadLine().ToLower();

                    if (keuzeBalkon == "woonkamer")
                    {
                        huidigeLocatie = "Woonkamer";
                    }
                    else
                    {
                        Console.WriteLine("\nOngeldige keuze.");
                    }
                }
                if (huidigeLocatie == "Wc")
                {
                    Console.WriteLine("\nJe voelt je niet lekker in de wc. Je verliest het spel.");
                    spelActief = false;
                }
            }

            Console.WriteLine("\nBedankt voor het spelen!");
            Console.WriteLine("Druk op een toets om af te sluiten.");
            Console.ReadKey();
        }
    }
}