using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace problema_sem_orientacao_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine(), CI);
            x.B = double.Parse(Console.ReadLine(), CI);
            x.C = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine(), CI);
            y.B = double.Parse(Console.ReadLine(), CI);
            y.C = double.Parse(Console.ReadLine(), CI);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine();
            Console.WriteLine("Area de x =" + areaX.ToString("F4", CI));
            Console.WriteLine("Area de y =" + areaY.ToString("F4", CI));

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            }else
            {
                Console.WriteLine("Maior area: Y");
            }

            Console.Read();
        }
        
    }
}
