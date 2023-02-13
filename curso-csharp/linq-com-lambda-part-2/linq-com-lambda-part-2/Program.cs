using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_com_lambda_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Computer", Price = 1345.00 });
            products.Add(new Product { Id = 2, Name = "Book", Price = 234.89 });
            products.Add(new Product { Id = 3, Name = "Tablet", Price = 1234.78 });
            products.Add(new Product { Id = 4, Name = "Pen", Price = 123.80 });

            var r1 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or default: " + r1);
        
        }
    }
}
