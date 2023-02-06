using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, altura, area, perimento, diagonal;

            Console.Write("Base do retangulo:");
            largura = double.Parse(Console.ReadLine(), CI);

            Console.Write("Altura do retangulo:");
            altura = double.Parse(Console.ReadLine(), CI);

            area = largura * altura;
            perimento = 2 * (largura + altura);
            diagonal = Math.Sqrt(Math.Pow(largura, 2.0) +Math.Pow(altura, 2.0));

            Console.WriteLine("Area = " + area.ToString("F4", CI));
            Console.WriteLine("Perimentro = " + perimento.ToString("F4", CI));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CI));
            Console.Read();
        }
    }
}
