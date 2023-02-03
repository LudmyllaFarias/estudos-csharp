using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace entrada_de_dados {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InstalledUICulture;

            // Entrada de dados
            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char temCnh;

            Console.Write("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();

            Console.Write("Digite o salário da primeira pessoa:");
            salario1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();

            Console.Write("Digite o salário da segunda pessoa:");
            salario2 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite uma idade:");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Informe se possui CNH (S/N):");
            temCnh = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome1 " + nome1);
            Console.WriteLine("Salário1 " + salario1.ToString("F2", CI));

            Console.WriteLine("Nome2 " + nome2);
            Console.WriteLine("Salário2 " + salario2.ToString("F2", CI));

            Console.WriteLine("Idade " + idade);

            Console.WriteLine("CNH " + temCnh);

            Console.Read();


        }
    }
}
