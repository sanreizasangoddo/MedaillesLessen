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
            Weapon Item1 = new Weapon("Goude Prikker", 10);
            Weapon Item2 = new Weapon("Glock", 13);

            List<Weapon> weaponList = new List<Weapon>();
            weaponList.Add(Item1);
            weaponList.Add(Item2);

            foreach (Weapon weapons in weaponList)
            {
                weapons.ShowStats();
            }
        }

        class Weapon
        {
            private string _name;
            private int _dmg;

            public Weapon(string name, int dmg)
            {
                _name = name;
                _dmg = dmg;
            }

            public void ShowStats()
            {
                Console.WriteLine($"De {_name} doet {_dmg} damage.");
            }

            public void UpgradeItem(int DamageToAdd)
            {

            }
        }
    }
}
