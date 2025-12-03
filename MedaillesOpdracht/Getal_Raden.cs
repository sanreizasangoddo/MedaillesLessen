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
            int guessnumber = 7;
            bool running = false;
            int maxnumber = 10;
            int attempts = 3;

            while (running)
            {
                Console.WriteLine("\nRaad het getal.");
                
                while(!int.TryParse(Console.ReadLine(), out guessnumber))
                {
                    Console.WriteLine("\nOngeldige invoer! Vul een nummer in.");
                }
                if (guessnumber == 7)
                {
                    
                }
            }

         
        }
    }
}