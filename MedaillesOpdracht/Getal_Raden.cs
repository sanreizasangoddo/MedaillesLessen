using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Getal_Raden
    {
        public void Start()
        {
            int maxNumber;
            int attempts = 0;
            int maxAttempts = 5;
            bool running = true;

            Console.WriteLine("Voer een maximum getal in:");

            while (!int.TryParse(Console.ReadLine(), out maxNumber) || maxNumber <= 10)
            {
                Console.WriteLine("Ongeldige invoer. Voer een geldig nummer in:");
            }

            Random random = new Random();
            int number = random.Next(1, maxNumber + 1);

            Console.Clear();
            Console.WriteLine($"Raad het getal tussen 1 en {maxNumber}");

            while (running)
            {
                int guess;
                attempts++;

                while (!int.TryParse(Console.ReadLine(), out guess))
                {
                    Console.WriteLine("Ongeldige invoer, probeer opnieuw:");
                    continue;
                }

                if (guess == number)
                {
                    Console.WriteLine($"\nGefeliciteerd! Je hebt het getal geraden in {attempts} pogingen!");
                    running = false;
                }
                else if (guess > number)
                {
                    Console.WriteLine($"Het getal is lager. Je hebt nog {maxAttempts - attempts} beurten over.");
                }
                else
                {
                    Console.WriteLine($"Het getal is hoger. Je hebt nog {maxAttempts - attempts} beurten over.");
                }

                if (attempts >= maxAttempts && running)
                {
                    Console.WriteLine($"\nGeen pogingen meer! Het getal was {number}.");
                    running = false;
                }
            }
        }
    }
}