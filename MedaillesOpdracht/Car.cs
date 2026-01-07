using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Car
    {
        private string _name;
        private string _brand;
        private int _amountOfDoors;

        public Car(string name, string brand, int amountOfDoors)
        {
            _name = name;
            _brand = brand;
            _amountOfDoors = amountOfDoors;
        }

        public void PrintCarInfo()
        {
            Console.WriteLine($"Auto naam: {_name} en merk: {_brand}");
        }
    }
}
