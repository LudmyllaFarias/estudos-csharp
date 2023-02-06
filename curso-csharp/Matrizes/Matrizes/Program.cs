using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, i, j;

            Console.Write("Quantas linhas vai ter a matriz:");
            M = int.Parse(Console.ReadLine());
            Console.Write("Quantas colunas vai ter a matriz:");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for(i = 0; i < M; i++)
            {
                for(j = 0; j < N; j++)
                {
                    Console.Write("Elemento [ " + i + "," + j + "]");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matriz digitada:");

            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.WriteLine(mat[i, j] + ",");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
