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

                if (keuzeTemperatuur <= 10 && keuzeWeer == "zonnig")
                {
                    Console.WriteLine("Je hebt echt wel een jas nodig vandaag.. Maar zonnebrand kan alsnog verstandig zijn!");
                }
            }
            else
            {
                Console.WriteLine("\nOngeldige keuze");
            }
        }
    }
}
