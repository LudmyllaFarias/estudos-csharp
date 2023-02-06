using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora;
            Console.Write("Digite uma hora do dia: ");
            hora = int.Parse(Console.ReadLine());

            if(hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }else
            {
                Console.WriteLine("Boa tarde!");
            }

            int x, soma;
            soma = 0;

            Console.Write("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {
                soma = soma + x;
                Console.Write("Digite o outro numero: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Soma " + soma);
            Console.Read();
        }
    }
}
