using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var menu = new List<Product>
            {
                new Pizza("Margherita", 30.00m, new List<string> {"tomato sauce", "mozzarella cheesee"} ),
                new Beverage("Coca-Cola", 8.00m, 500),
                new Sauce("Barbeque", 3.00m, "mild")
            };

           

            Console.WriteLine("Enter 1 number to show menu");
            var choise = int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    menu.ForEach(Console.WriteLine);
                        break;
                default:
                    Console.WriteLine("Invalid Value");
                    break;

            }

        }
    }
}
