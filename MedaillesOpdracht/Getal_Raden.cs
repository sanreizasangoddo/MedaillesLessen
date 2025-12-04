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
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int number = numberArray[8];
            bool running = false;
            int maxnumber = 20;
            int attempts = 5;

            while (running)
            {
                if (maxnumber <= 20)
                {
                    Console.WriteLine("\nRaad het getal.");
                    maxnumber = maxnumber + 1;
                }
                int answer;
                while (!int.TryParse(Console.ReadLine(), out answer))
                {
                    Console.Clear();
                    attempts = attempts - 1;
                    Console.WriteLine($"\nOngeldig invoer. Dit kost één poging. Pogingen over: {attempts}");
                }
                Console.Clear();
                if (answer == 8)
                {
                    running = false;
                    Console.WriteLine("\nGefeliciteerd! Je hebt het getal geraden!");
                }
                else if (answer > 8)
                {
                    Console.Clear();
                    attempts = attempts - 1;
                    Console.WriteLine("\nJe hebt het getal nog niet geraden, het is lager.");
                }
                else if (answer < 8)
                {
                    Console.Clear();
                    attempts = attempts - 1;
                    Console.WriteLine("\nJe hebt het getal nog niet geraden, het is hoger");
                }
            }
        }
    }
}