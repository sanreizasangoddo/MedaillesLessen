using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Tafels_Generator
    {
        public void Start()
        {
           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

           for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"5 x {i} = {5 * i}");
            }

            Console.WriteLine("\nKies een tafel");
            int keuzeTafel;

            while (!int.TryParse(Console.ReadLine(), out keuzeTafel))
            {
                Console.WriteLine("\nOngeldige invoer! Vul een nummer in.");
            }

            Console.WriteLine("\nKies nu tot hoeveel jij wilt doorrekenen.");
            int keuzeStop;

            while (!int.TryParse(Console.ReadLine(), out keuzeStop))
            {
                Console.WriteLine("\nOngeldige invoer! Vul een nummer in.");
            }

            for (int i = 1; i <= keuzeStop; i++)
            {
                Console.WriteLine($"{keuzeTafel} x {i} = {keuzeTafel * i}");
            }
        }
    }
}
