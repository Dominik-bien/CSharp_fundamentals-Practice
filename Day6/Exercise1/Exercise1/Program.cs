using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var hero = new Hero("Knight", 100, 20);

            List<IAttacked> targets = new List<IAttacked>
            {
                new Monster("Orc", 60, 10),
                new Barrel("Beer barrel", 15),
                new Monster("Zombie", 70, 5)
            };

            Console.WriteLine("Adventure has started");
            hero.showDescription();
            Console.WriteLine("---------------------");

            foreach (var target in targets)
            {
                Console.WriteLine($"\nIn the way is: {target.Name} ({target.Health})");

                while (target.isAlive() && hero.isAlive())
                {
                    if (target is Character character)
                        hero.Attack(character);
                    
                    else
                        hero.Attack(target);

                    if (!target.isAlive())
                    {
                        Console.WriteLine($"{target.Name} was defeated");
                        break;
                    }


                    if (target is Character)
                    {
                        Character enemy = (Character)target;
                        enemy.Attack(hero);
                        Console.WriteLine($"\n{hero.Name} HP: {hero.Health}");
                    }

                }
                if (!hero.isAlive())
                {
                    Console.WriteLine("Hero was defeated. Game Over!!");
                    break;
                }

                Console.WriteLine("\n--------------------------");
              
                }

            if (hero.isAlive())
            {
                {
                    Console.WriteLine("All target were defealted. Gratulations");
                }
            }
        }
    }
}
