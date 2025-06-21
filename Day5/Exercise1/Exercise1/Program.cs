using System;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Hero = new Hero("Knight", 100, 15);
            var Monster = new Monster("Werewolf", 120, 20);

            Console.WriteLine("The Fight has started");
            Console.WriteLine($"{Hero.name} (HP: {Hero.health}) vs {Monster.name} (HP: {Monster.health})");
            Console.WriteLine("-------------------------------");

            while (Hero.isAlive() && Monster.isAlive())
            {
                //Hero Turn 
                Hero.Attack(Monster);
                Console.WriteLine($"{Monster.name} now has {Monster.health} HP.");

                if (!Monster.isAlive())
                {
                    break;
                }

                Console.WriteLine("-------------------------------");
                //Monster Turn
                Monster.Attack(Hero);
                Console.WriteLine($"{Hero.name} now has {Hero.health} HP");
                Console.WriteLine("-------------------------------");




            }

            Console.WriteLine("The fight has finished");

            if (Hero.isAlive())
            {
                Console.WriteLine($"{Hero.name} won.\n{Hero.name}'s HP: {Hero.health}");
            }
            else
            {
                Console.WriteLine($"The {Monster.name} was stronger than {Hero.name}. {Hero.name} died\nMonster's HP: {Monster.health}");
            }
        }
    }
}
