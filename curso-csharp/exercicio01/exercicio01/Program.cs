using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa1.salario = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            pessoa2.salario = double.Parse(Console.ReadLine(), CI);

            double media = (pessoa1.salario + pessoa2.salario) / 2.0;

            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Salário: " + pessoa1.salario);

            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Salário: " + pessoa2.salario);

            Console.WriteLine("Salário medio: " + media.ToString("F2", CI));

            Console.Read();



        }
    }
}
