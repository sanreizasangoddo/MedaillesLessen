using System;
using System.Collections.Generic;
using System.Linq;
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

            List<Character> characters = new List<Character>();
            characters.Add(c1);
            characters.Add(c2);
            characters.Add(c3);

            for (int i = 0; i < characters.Count; i++)
            {
                characters[i].ShowStats();
            }
        }
    }

    class Character
    {
        public string Name;
        public int Level;
        public int Lives;

        public Character(string name, int level, int lives)
        {
            Name = name;
            Level = level;
            Lives = lives;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Naam: {Name}, Level: {Level}, Levens: {Lives}");
        }
    }
}