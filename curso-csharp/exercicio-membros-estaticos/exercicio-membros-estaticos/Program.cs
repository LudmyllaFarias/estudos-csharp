using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_membros_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            ConversorDeMoeda conversor = new ConversorDeMoeda();

            Console.Write("Qual é a contação do dólar? ");
            double dolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolares = double.Parse(Console.ReadLine());

            Console.Write("Valor a ser pago em reais: " + ConversorDeMoeda.ValorPagoEmReais(qtdDolares, dolar).ToString("F2", CI));
            Console.Read();
        }
    }
}
