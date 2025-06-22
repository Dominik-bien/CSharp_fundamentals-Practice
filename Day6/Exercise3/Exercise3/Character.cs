using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int AttackPower {get; protected set; }

        public Character(string name, int hp, int attackpower)
        {
            Name = name;
            Health = hp;
            MaxHealth = hp;
            AttackPower = attackpower;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
            Console.WriteLine($"{Name} takes {damage} Damage!");
        }
        public bool isAlive() => Health > 0;

        public abstract void ExecuteBattleCry();


    }
}
