using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecicio_diagonal_negativo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, numerosNegativo = 0;

            Console.Write("Qual a ordem da matriz?");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N, N];

            for(int i = 0; i < N; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "," + j + "]");
                   
                    mat[i, j] = int.Parse(Console.ReadLine());
                    
                    if (mat[i, j] < 0)
                    {
                        numerosNegativo += 1;
                    }
                }
            }

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < N; i++)
            {
                Console.Write(mat[i, i] + " ");
            }

            Console.WriteLine();
            Console.Write("Negativos: " + numerosNegativo);
            Console.Read();

           
        }
    }
}
