using System;
using System.Linq;

namespace introducao_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 2, 3, 4, 5, };

            //Define the query expression
            var result = numeros.Where(x => x % 2 == 0).Select(x => x * 10);


            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

            Console.Read();
        }

    }
}
