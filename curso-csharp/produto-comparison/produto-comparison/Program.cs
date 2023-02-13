using System;
using System.Collections.Generic;

namespace produto_comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> list = new List<Produto>();

            list.Add(new Produto("TV", 900.00));
            list.Add(new Produto("Tablet", 1200.00));
            list.Add(new Produto("Notebook", 450.00));

            // Expressao lamba funcao anonima
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

            foreach (Produto p in list) 
            { 
                Console.WriteLine(p);
            }
            Console.Read();
        }
    }
}
