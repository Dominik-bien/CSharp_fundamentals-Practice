using System;
using System.Collections.Generic;


namespace Exercise2
{
    public class Inventory
    {
        private Dictionary<string, int> _items = new Dictionary<string, int>();

        public void AddItems(string name, int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("You cannot add 0 and subtract the number of items");
                return;
            }

            if (_items.ContainsKey(name))
            {
                _items[name] += amount;
                Console.WriteLine($"Add {amount} amount {name}. You have now: {_items[name]}");
            }
            else
            {
                _items.Add(name, amount);
                Console.WriteLine($"Add new item: {name} (amount: {amount})");
            }
        }

        public void RemoveItems(string name, int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount items to delete must be positive");
                return;
            }

            if (!_items.ContainsKey(name))
            {
                Console.WriteLine($"You do not have item: {name}.");
                return;
            }

            if (_items[name] < amount)
                Console.WriteLine($"You can not delete {amount} amount {name} because, you have only {_items[name]}. ");
            else
            {
                _items[name] -= amount;
                Console.WriteLine($"Remove {amount} amount of {name}. Remains: {_items[name]}. ");

                if (_items[name] == 0)
                {
                    _items.Remove(name);
                    Console.WriteLine($"Item {name} has been remove from Inventory");
                }
            }
        }


        public void showInventory()
        {
            Console.WriteLine("\n----INVENTORY------");
            if (_items.Count == 0)
                Console.WriteLine("Inventory is empty");
            else
            {
                foreach (var item in _items)
                {
                    Console.WriteLine($" - {item.Key}: {item.Value} amount.");
                }
            }
            Console.WriteLine("-----------------\n");
        }
    


    }
}
