
using System.Collections.Generic;


namespace Exercise1
{
    public class Pizza : Product
    {
        public List<string> Ingredients { get; set; }

        public Pizza(string name, decimal price, List<string> ingredients)
        {
            this.Name = name;
            this.Price = price;
            this.Ingredients = ingredients;
        }

        public override string Description()
        {
            return $"{Name} (Ingredients: {string.Join(", ", Ingredients)}) - {Price} PLN";
        }
    }
}
