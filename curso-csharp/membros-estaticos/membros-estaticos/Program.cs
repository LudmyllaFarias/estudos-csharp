using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace membros_estaticos
{
    class Program
    {
      
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Calculadora calc = new Calculadora();

            Console.Write("Entre o valor do raio:");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));

            Console.WriteLine("Volume: " + vol.ToString("F2", CI));

            Console.WriteLine("PI: " + Calculadora.PI.ToString("F2", CI));

            Console.Read();
        }
     
    }
}
