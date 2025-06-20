

namespace Exercise1
{
    public class Beverage : Product
    {

        public Beverage(string Name, decimal Price, int BeverageCapacity) {
            this.Name = Name;
            this.Price = Price;
            this.BeverageCapacity = BeverageCapacity;
        }
        public int BeverageCapacity { get; set; }

        public override string Description()
        {
            return $"Beverage {Name} ({BeverageCapacity})ml - {Price} PLN";
            
        }
    }
}
