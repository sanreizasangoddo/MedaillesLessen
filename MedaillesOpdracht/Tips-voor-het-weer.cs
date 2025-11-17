using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Tips_voor_het_weer
    {
        public void Start()
        {
            Console.WriteLine("Hallo, wat voor weer is het?");
            Console.WriteLine("(Typ 'Zonnig', 'regen' of 'bewolkt')");
            string keuzeWeer = Console.ReadLine().ToLower();

            if (keuzeWeer == "zonnig" || keuzeWeer == "regen" || keuzeWeer == "bewolkt")
            {
                Console.WriteLine("\nHoeveel graden is het?");
                int keuzeTemperatuur = Convert.ToInt32(Console.ReadLine());

                if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 10 && keuzeWeer == "zonnig")
                {
                    Console.WriteLine("Je hebt echt wel een jas nodig vandaag.. Maar zonnebrand kan alsnog verstandig zijn!");
                }
                else if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 10 && keuzeWeer == "regen")
                {
                    Console.WriteLine("Je hebt echt wel een jas nodig vandaag... Een paraplu kan ook verstandig zijn...");
                }
                else if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 10 && keuzeWeer == "bewolkt")
                {
                    Console.WriteLine("Je hebt echt wel een jas nodig vandaag...");
                }
                else if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 20 && keuzeWeer == "zonnig")
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag geniet lekker van de zon!");
                }
                else if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 20 && keuzeWeer == "regen")
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, maar zorg wel dat je je capuchon aan hebt voor het regen!");
                }
                else if (keuzeTemperatuur >= 0 && keuzeTemperatuur <= 20 && keuzeWeer == "bewolkt")
                {
                    Console.WriteLine("Je hebt geen jas nodig vandaag, helaas kan je niet van de zon genieten vanwege de bewolking...");
                }
                else
                {
                    Console.WriteLine("\nOngeldige antwoord.");
                }
            }
            else
            {
                Console.WriteLine("\nOngeldige antwoord.");
            }
        }
    }
}