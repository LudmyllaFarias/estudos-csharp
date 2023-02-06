using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecicio_menos_de_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, numero3, menor;

            Console.Write("Primeiro valor:");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Segundo valor:");
            numero2 = int.Parse(Console.ReadLine());

            Console.Write("Terceiro valor:");
            numero3 = int.Parse(Console.ReadLine());

            if(numero1 < numero2)
            {
                menor = numero1;
            }else if (numero2 < numero3)
            {
                menor = numero2;
            }else
            {
                menor = numero3;
            }

            Console.WriteLine("MENOR = " + menor);
            Console.Read();
        }
    }
}
