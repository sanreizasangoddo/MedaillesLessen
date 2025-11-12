using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, wat is jouw naam en leeftijd?");
            string naam = Console.ReadLine();
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Hoi " + naam + ", jij bent " + leeftijd + " jaar oud!");
        }
    }
}
