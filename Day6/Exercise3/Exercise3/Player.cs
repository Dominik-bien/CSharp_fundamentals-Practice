using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Player : Character
    {
        public int Level { get; private set; } = 1;
        public int XP { get; private set; } = 0;
        public int Gold { get; private set; } = 50;

        private List<Item> _inventory = new List<Item>();

        public Player(string name, int hp, int attakpower) : base(name, hp, attakpower) { }

        public void AddToInventory(Item item)
        {
            _inventory.Add(item);
            Console.WriteLine($"You gained: {item.Name}");
        }

        public void ShowInventory()
        {
            Console.WriteLine("---INVENTORY----");
            if (_inventory.Count == 0)
            {
                Console.WriteLine("EMPTY");
                return;
            }
            for (int i = 0; i < _inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {_inventory[i].Name} - {_inventory[i].Description}");
            }
            Console.WriteLine("---------------");
        }
        public void UseItem(int index)
        {
            if (index < 0 || index >= _inventory.Count)
            {
                Console.WriteLine("Invalid item number");
                return;
            }

            var item = _inventory[index];
            if (item.HpHeal > 0)
            {
                this.Health += item.HpHeal;
                if (this.Health > this.MaxHealth)
                    this.Health = this.MaxHealth;

                Console.WriteLine($"Used {item.Name}, gained: {item.HpHeal} HP.");
                _inventory.RemoveAt(index);
            }
            else
                Console.WriteLine($"You can not use {item.Name} in the way");
        }

            public void AddGold(int amount) => Gold += amount;
            public bool SpendGold(int amount)
        {
            if (Gold >= amount)
            {
                Gold -= amount;
                return true;
            }
            return false;
        }


        public override void ExecuteBattleCry()
        {
            Console.WriteLine($"{Name} shouts!!!: Carai an Ellisande!");
        }
    }

    
}