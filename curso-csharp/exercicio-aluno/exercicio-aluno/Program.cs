using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            Aluno aluno = new Aluno();

            Console.Write("Nome da aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.NotaFinal().ToString("F2", CI));

            if(aluno.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                 + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                 + " PONTOS");
            }

            Console.Read();
        }
    }
}
