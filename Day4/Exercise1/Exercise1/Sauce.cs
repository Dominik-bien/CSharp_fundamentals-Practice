

namespace Exercise1
{
    public class Sauce : Product
    {
        public Sauce(string Name, decimal Price,  string spiciness) {
        this.Name = Name;  
        this.Price = Price;
        this.spiciness = spiciness;
        }
        public string spiciness { get; set; }

        public override string Description()
        {
            return $"Sauce {Name} ({spiciness}) - {Price} PLN";

        }


    }
}
