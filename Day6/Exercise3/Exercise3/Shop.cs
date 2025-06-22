using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Shop
    {
        private Dictionary<string, Item> _resources = new Dictionary<string, Item>();

        public Shop()
        {
            _resources.Add("potion of health", new Item("Potion of Health", "Healed 25 HP", 20, 25));
            _resources.Add("super potion of health", new Item("Super potion of health", "Healed 100 HP", 75, 100));
            _resources.Add("hearthstone", new Item("Hearthstone", "Possible to escape from combat", 50));
        }

        public void ShowResources()
        {
            Console.WriteLine("----Welcome to Shop----");
            foreach (var item in _resources.Values)
            {
                Console.WriteLine($" - {item.Name} [{item.Cost} Gold: {item.Description}");
            }
            Console.WriteLine("-----------------------");
        }

        public void Sell(Player player, string itemName)
        {
            itemName = itemName.ToLower();
            if (_resources.TryGetValue(itemName, out Item item))
            {
                if (player.SpendGold(item.Cost))
                {
                    player.AddToInventory(item);
                }
                else
                {
                    Console.WriteLine("You do not have enough money!!");
                }
            }
            else
            {
                Console.WriteLine("We do not have item.");
            }
        }
    }
}
