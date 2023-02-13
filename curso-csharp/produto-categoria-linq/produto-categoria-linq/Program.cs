using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace produto_categoria_linq
{
    internal class Program
    {
        static void Print<T> (string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Ling com lambda  
            var c1 = new Category(1, "Eletronics", 1);
            var c2 = new Category(2, "Fashion", 2);
            var c3 = new Category(3, "Books", 3);
  


            List<Product> products = new List<Product>();
            new Product() { Id = 1, Name = "Computer", Price = 2049.00, Category = c1 };
            new Product() { Id = 2, Name = "Coat", Price = 453.00, Category = c2 };
            new Product() { Id = 3, Name = "Tablet", Price = 1234.09, Category = c1 };
            new Product() { Id = 4, Name = "Livro JavaScript", Price = 234.90, Category = c3 };
            new Product() { Id = 5, Name = "Celular", Price = 547.78, Category = c1 };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.00);
            Print("Tier 1 and price < 900" , r1);

            var r2 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoraName = p.Category.Name});
            Print("Names started with 'C'", r2);

            var r4 = products.Where(p => p.Category.Name == "Books").Select(p => p.Name);
            Print("Category with name equal Books ", r4);

            Console.WriteLine("Category with name equal" + r4.ToList());

            //Linq com notacao similar ao sql
            var r5 = from p in products
                     where p.Category.Tier == 1 && p.Price < 900.00
                     select p;
            Console.WriteLine(r5);
            Console.Read();
        }
    }
}
