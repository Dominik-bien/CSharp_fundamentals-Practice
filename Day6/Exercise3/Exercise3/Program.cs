namespace Exercise3
{
    class Program
    {
        private static Player player;
        private static Shop shop;
        private static Random random = new Random();

        static void Main(string[] args)
        {
            IniclializeGame();
            MainGameLoop();
        }

        private static void MainGameLoop()
        {
            while (player.isAlive())
            {
                Console.WriteLine("\n-----Tasks-------");
                Console.WriteLine("1.Go to the adventure");
                Console.WriteLine("2.Visit the shop");
                Console.WriteLine("3.Show inventory and stats");
                Console.WriteLine("4.Exit the game");
                Console.WriteLine("Choose: ");

                switch (Console.ReadLine())
                    {
                    case "1":  GoAdventure(); break;
                    case "2": VisitTheShop(); break;
                    case "3": ShowPlayerStats(); break;
                    case "4": return;
                    default: Console.WriteLine("Invalid command"); break;
                }
            }
        }

        private static void ShowPlayerStats()
        {
            Console.WriteLine("\n----STATS------");
            Console.WriteLine($"Player NAME: {player.Name} ---");
            Console.WriteLine($"HP {player.Health}/{player.MaxHealth} | ATTACK POWER: {player.AttackPower} | GOLD: {player.Gold}");
            player.ShowInventory();
        }

        private static void VisitTheShop()
        {
            shop.ShowResources();
            Console.WriteLine("Enter item name to buy or write 'exit' to exit shop");
            string choise = Console.ReadLine();
            if (choise.ToLower() != "exit")
                shop.Sell(player, choise);
        }

        private static void GoAdventure()
        {
            var monster = CreateRandomMonster();
            Console.WriteLine($"\nYou meet {monster.Name}!");

            player.ExecuteBattleCry();
            monster.ExecuteBattleCry();

            while (player.isAlive() && monster.isAlive())
            {
                Console.WriteLine("\n----PLAYER TURN----");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Use item from Inventory");
                Console.WriteLine("3. Escape");

                switch (Console.ReadLine())
                {
                    case "1":
                        player.TakeDamage(monster.AttackPower);
                        monster.TakeDamage(player.AttackPower);
                        break;
                    case "2":
                        player.ShowInventory();
                        Console.WriteLine("Enter item to use: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            player.UseItem(index - 1);
                        }
                        player.TakeDamage(monster.AttackPower);
                        break;
                    case "3":
                        Console.WriteLine("You escape from fight");
                        return;
                }
                ShowBattleInfo(monster);
            }
            if (player.isAlive())
            {
                Console.WriteLine($"Winning! You defeated {monster.Name} and gained {monster.GoldForDefeat} gold.");
                player.AddGold(monster.GoldForDefeat);
            }
        }

        static Monster CreateRandomMonster()
        {
            List<Monster> monsters = new List<Monster>
            {
                new Monster("Orc", 60, 20, 40),
                new Monster("The big spider", 45, 15, 25),
                new Monster("Ghost", 200, 30, 30)
            };
            return monsters[random.Next(monsters.Count)];
        }
private static void ShowBattleInfo(Monster monster)
        {
            Console.WriteLine($"Player HP: {player.Health}/{player.MaxHealth}");
            Console.WriteLine($"Monster HP: {monster.Health}/{monster.MaxHealth}");
        }

        private static void IniclializeGame()
        {
            Console.WriteLine("Welcome to RPG. Enter name for your HERO: ");
            string name  = Console.ReadLine();
            player = new Player(name, 100, 15); 
            shop = new Shop();
        }


    }
}