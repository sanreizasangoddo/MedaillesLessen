using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Loops
    {
        public void Start()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("For loop");

            int a = 1;
            while(a <= 10)
            {
                Console.WriteLine(a);
                a = a + 1;
            }
            Console.WriteLine("While loop");

            int[] b = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            foreach (int number in b)
            {
                Console.WriteLine(number);         
            }
            Console.WriteLine("Foreach loop");

            int c = 1;
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c <= 10);
            Console.WriteLine("Do-while loop");
        }
    }
}
