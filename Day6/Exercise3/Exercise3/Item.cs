using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    public class Item
    {
        public string Name { get; }
        public string Description { get; }
        public int Cost { get; }
        public int HpHeal { get; }

        public Item(string name, string description, int cost, int hpheal = 0)
        {
            Name = name;
            Description = description;
            Cost = cost;
            HpHeal = hpheal;
                
        }
    }
}
