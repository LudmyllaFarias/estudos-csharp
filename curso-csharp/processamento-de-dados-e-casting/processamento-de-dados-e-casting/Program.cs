using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace processamento_de_dados_e_casting {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
  
            int x;
            double y;

            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y.ToString("F2", CI));

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b2 + b2) / 2.0 * h;

            Console.WriteLine("Area " +  area.ToString("F2", CI));

            int a, b;
            double resultado;

            a = 5;
            b = 2;
            resultado = (double)a / b;

            Console.WriteLine("Divisão " + resultado);

            double c;
            int d;

            c = 5.2;
            d = (int)a;

            Console.WriteLine("Casting " + d);

            Console.Read();
        }
    }
}
