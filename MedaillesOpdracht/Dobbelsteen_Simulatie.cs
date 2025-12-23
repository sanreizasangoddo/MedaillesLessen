using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    class Dobbelsteen_Simulatie
    {
        public void Start()
        {
            Random random = new Random();
            int[] count = new int[6];
            int totalThrows = 100;

            for (int i = 0; i < totalThrows; i++)
            {
                int @throw = random.Next(1, 7);
                count[@throw - 1]++;
            }

            int maxAmount = 0;
            int mostThrown = 0;

            for (int i = 0; i < count.Length; i++)
            {
                double percentage = (count[i] / (double)totalThrows) * 100;
                Console.WriteLine($"{i + 1}: {count[i]} keer ({percentage:F2}%)");

                if (count[i] > maxAmount)
                {
                    maxAmount = count[i];
                    mostThrown = i + 1;
                }
            }
            Console.WriteLine($"\nMeest gegooid getal: {mostThrown} ({maxAmount} keer)");
        }
    }
}