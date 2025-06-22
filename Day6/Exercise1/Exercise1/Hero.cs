

using System;

namespace Exercise1
{
    public class Hero : Character
    {
        public Hero(string Name, int Health, int AttackPower) : base(Name, Health, AttackPower)
        {
        }

        public override void showDescription()
        {
            Console.WriteLine($"This is hero: {Name}");
        }

        public void Attack(IAttacked target)
        {
            target.TakeDamage(this.AttackPower);
        }

    }
}
