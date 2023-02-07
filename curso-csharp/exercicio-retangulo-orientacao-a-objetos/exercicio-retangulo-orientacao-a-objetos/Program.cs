using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_retangulo_orientacao_a_objetos
{
    class Program
    {
        static void Main(string[] args)

        {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo rentangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo:");
            rentangulo.Altura = double.Parse(Console.ReadLine());
            rentangulo.Largura = double.Parse(Console.ReadLine());

            Console.Write("AREA = " + rentangulo.Area().ToString("F2", CI));
            Console.WriteLine();
            Console.Write("PERIMETRO = " + rentangulo.Perimentro().ToString("F2", CI));
            Console.WriteLine();
            Console.Write("DIAGONAL = " + rentangulo.Diagonal().ToString("F2", CI));
            Console.Read();
        }
    }
}
