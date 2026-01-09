using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedaillesOpdracht
{
    internal class Item_Constructor_RPG
    {
        public void Start()
        {
            Weapon Item1 = new Weapon("Goude Prikker", 20, "Melee");
            Weapon Item2 = new Weapon("Glock", 12, "Ranged");
            Weapon Item3 = new Weapon("Speer", 14, "Melee/Ranged");
            Weapon Item4 = new Weapon("Bom", 45, "Explosive");
            Weapon Item5 = new Weapon("Kettingzaag", 25, "Melee");
            Weapon Item6 = new Weapon("Knuppel", 18, "Blunt");

            List<Weapon> weaponList = new List<Weapon>()
            {
                Item1,
                Item2,
                Item3,
                Item4,
                Item5,
                Item6
            };

            foreach (Weapon weapon in weaponList)
            {
                weapon.ShowStats();
            }

            Console.WriteLine("\n--- Upgrades ---");

            foreach (Weapon weapon in weaponList)
            {
                weapon.UpgradeItem(3);
            }

            Console.WriteLine("\n--- Na upgrade ---");

            foreach (Weapon weapon in weaponList)
            {
                weapon.ShowStats();
            }
        }

        class Weapon
        {
            private string _name;
            private int _dmg;
            private string _type;

            public Weapon(string name, int damage, string type)
            {
                _name = name;
                _dmg = damage;
                _type = type;
            }

            public void ShowStats()
            {
                Console.WriteLine($"\nWeapon: {_name}");
                Console.WriteLine($"Damage: {_dmg}");
                Console.WriteLine($"Weapon Type: {_type}");
            }

            public void UpgradeItem(int damageToAdd)
            {
                _dmg += damageToAdd;
                Console.WriteLine($"{_name}: + 3 dmg");
            }
        }
    }
}