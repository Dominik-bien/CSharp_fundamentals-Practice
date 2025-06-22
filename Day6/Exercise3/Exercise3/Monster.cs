using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Monster : Character
    {
        public int GoldForDefeat { get; private set; }

        public Monster(string name, int hp, int attackpower, int gold) : base(name, hp, attackpower)
        {
            GoldForDefeat = gold;
        }

        public override void ExecuteBattleCry()
        {
            Console.WriteLine($"{Name} Shouts!!!");
        }
    }
}
