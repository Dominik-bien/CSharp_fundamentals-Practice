using System;
using System.Collections.Generic;

namespace Exercise1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual string Description()
        {
            return string.Empty;
        }

        public override string ToString()
        {
            return Description();
        }

    }
}
