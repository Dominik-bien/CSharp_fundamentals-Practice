using System;


namespace Exercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("Choose option: ");
                Console.WriteLine("1.Add item");
                Console.WriteLine("2.Remove item");
                Console.WriteLine("3.Show inventory");
                Console.WriteLine("4.End");

                string choise = Console.ReadLine();

                switch(choise)
                {
                    case "1":
                        Console.WriteLine("Enter item name to add: ");
                        string itemName = Console.ReadLine();
                        Console.WriteLine("Enter amount: ");
                        if (int.TryParse(Console.ReadLine(), out int itemAmount))
                            inventory.AddItems(itemName, itemAmount);
                        else
                        {
                            Console.WriteLine("Invalid value.");
                        }
                            break;

                        case "2":
                        Console.WriteLine("Enter a name item to remove: ");
                        string itemDeleteName = Console.ReadLine();
                        Console.WriteLine("Enter amount: ");
                        if (int.TryParse(Console.ReadLine(), out int amountItemToDelete))
                            inventory.RemoveItems(itemDeleteName, amountItemToDelete);
                        else
                        {
                            Console.WriteLine("Invalid Value");
                        }
                        break;
                    case "3":
                                inventory.showInventory();
                                break;

                            case "4":
                                Console.WriteLine("Exit from Inventory");
                                return;

                            default:
                                Console.WriteLine("Invalid option. Choose the number 1-4");
                                break;
                            }
            }
        }

        
    }
}
