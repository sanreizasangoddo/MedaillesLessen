using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Game_Karakter_met_Constructor
    {
        public void Start()
        {
            Character c1 = new Character("Speler1", 5, 3);
            Character c2 = new Character("Speler2", 10, 5);
            Character c3 = new Character("Boss", 20, 1);

            List<Character> charList = new List<Character>();
            charList.Add(c1);
            charList.Add(c2);
            charList.Add(c3);

            for (int i = 0; i < charList.Count; i++)
            {
                charList[i].ShowStats();
            }
        }
    }

    class Character
    {
        private string _name;
        private int _lvl;
        private int _lives;

        public Character(string name, int level, int lives)
        {
            _name = name;
            _lvl = level;
            _lives = lives;
        }

        public void ShowStats()
        {
            Console.WriteLine($"\nName: {_name}");
            Console.WriteLine($"Level: {_lvl}");
            Console.WriteLine($"Lives: {_lives}");
        }
    }
}