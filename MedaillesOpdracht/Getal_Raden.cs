using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Getal_Raden
    {
        public void Start()
        {
            bool running = false;
            int maxnumber = 0;
            int attempts = 3;

            while (running)
            {
                if (maxnumber == 0)
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
            }

         
        }
    }
}