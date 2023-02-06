using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace excecicio_soma_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
           
            int N;
            double media, soma;

            Console.Write("Quantos números você vai digitar:");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];

            soma = 0;

            for(int i = 0;  i < N; i++)
            {
                Console.WriteLine("Digite um número:");
                vet[i] = double.Parse(Console.ReadLine(), CI);
                soma = soma + vet[i];
            }

            media = soma / N;

            for(int i = 0; i < N; i++)
            {
                Console.WriteLine("VALORES = " + vet[i].ToString("F1", CI));
            }

            Console.WriteLine();
            Console.WriteLine("SOMA = "+ soma.ToString("F2", CI));
            Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            Console.Read();
        }
    }
}
