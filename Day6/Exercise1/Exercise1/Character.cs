using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public abstract class Character : IAttacked
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int AttackPower { get; private set; }

        public Character(string Name, int Health, int AttackPower)
        {
            this.AttackPower = AttackPower;
            this.Health = Health;
            this.Name = Name;
        }

        public void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacks {Name} and dealted {AttackPower} damage");
            target.TakeDamage(AttackPower);
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
                Health = 0;
        }
        public bool isAlive()
        {
            return Health > 0;
        }

        public abstract void showDescription();
    }
}
