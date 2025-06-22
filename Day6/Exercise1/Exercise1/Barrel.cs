using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Barrel : IAttacked
    {
        public string Name { get; private set; }
        public int Health { get; private set; }

        public Barrel(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"Barrel has destroyed");
            }
            else
            {
                Console.WriteLine($"{Name} takes {damage} damages. It has been {Health} HP");
            }

        }
        public bool isAlive()
        {
            return Health > 0;
        }
    }
}
