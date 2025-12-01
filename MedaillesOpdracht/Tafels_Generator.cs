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
            int keuzeTafel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nKies nu tot hoeveel jij wilt doorrekenen.");
            int keuzeStop = Convert.ToInt32(Console.ReadLine());

           for (int i = 1; i <= keuzeStop; i++)
            {
                Console.WriteLine($"{keuzeTafel} x {i} = {keuzeTafel * i}");
            }
        }
    }
}
