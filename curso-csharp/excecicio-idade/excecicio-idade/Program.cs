using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace excecicio_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade1, idade2;
            string nome1, nome2;
            double media;

            Console.Write("Digite o nome da primeira pessoa:");
            nome1 = Console.ReadLine();

            Console.Write("Digite a idade da primeira pessoa:");
            idade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa:");
            nome2 = Console.ReadLine();

            Console.Write("Digite a idade da segunda pessoa:");
            idade2 = int.Parse(Console.ReadLine());

            media = (idade1 + idade2) / 2.0;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " e de " + media.ToString("F2", CI));
            Console.Read();
            
        }
    }
}
