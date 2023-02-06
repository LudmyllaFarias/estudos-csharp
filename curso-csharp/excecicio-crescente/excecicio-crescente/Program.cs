using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecicio_crescente
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("CRESCENTE!");
                }
                else
                {
                    Console.WriteLine("DESCRESCENTE!");
                }

                Console.WriteLine("Digite outros dois números:");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

            }
            Console.Read();
        }
    }
}
