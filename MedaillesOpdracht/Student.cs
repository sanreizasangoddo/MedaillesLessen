using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Student
    {
        private string _name;
        private int _age = 16;
        private string _surname;
        private string _friendname;
        public Student(string name, int age, string surname, string friendname)
        {
            _name = name;
            _age = age;
            _surname = surname;
            _friendname = friendname;
            Console.WriteLine($"Dit student met de naam {_name} is gemaakt!");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello, nice to meet you!");
        }

        public void Introduction()
        {
            Console.WriteLine($"My name is {_name + _surname}. I am {_age} years old.");
        }

        public void Friend()
        {
            Console.WriteLine($"This is my friend, {_friendname}.");
        }
    }
}
