using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecicio_soma_impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, troca, soma;

            Console.WriteLine("Digite dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                troca = x;
                x = y;
                y = troca;
            }
            soma = 0;

            for(int i = x+1; i < y; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }

            Console.WriteLine("Soma dos impares = " + soma);
            Console.Read();
        }
    }
}
