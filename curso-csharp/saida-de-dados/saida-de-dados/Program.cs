using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace saida_de_dados {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("com quebra de linha");
            Console.Write("sem quebra de linha");

            int x, y;
            x = 10;
            y = 20;

            Console.WriteLine(x);
            Console.WriteLine(y);


            double a;
            a = 1023.43;

            Console.WriteLine(a.ToString("F2", CI));

            int idade;
            double salario;
            string nome;
            char cnh;

            idade = 20;
            salario = 4000.4;
            nome = "Maria Silva";
            cnh = 's';

            Console.WriteLine("A funcionária " + nome + ", tem cnh? " + cnh + ", ganha "
                + salario.ToString("F2", CI) + " e tem " + idade);

            Console.Read();
        }
    }
}
