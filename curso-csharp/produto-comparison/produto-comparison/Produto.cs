using System;
using System.Globalization;

namespace produto_comparison
{
    internal class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        internal object ToUpper()
        {
            throw new NotImplementedException();
        }
    }
}
