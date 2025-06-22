using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Monster : Character
    {
        public Monster(string Name, int Health, int AttackPower) : base(Name, Health, AttackPower)
        {
        }
        public override void showDescription()
        {
            Console.WriteLine($"This is the scary monster: {Name}");
        }
    }
}
