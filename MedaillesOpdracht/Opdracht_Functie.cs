using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class OpdrachtFunctie
    {
        public void Start()
        {
            Console.WriteLine(CheckIfNumberIsPositive(3));
        }
        private static bool CheckIfNumberIsPositive(int getal)
        {
            return getal > 0;
        }
    }
}