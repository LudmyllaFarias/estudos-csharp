using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Salário: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Funcionário: " + pessoa);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentat o salário: ");
            pessoa.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados atualizados: " + pessoa);
            Console.ReadLine();
        }
    }
}
