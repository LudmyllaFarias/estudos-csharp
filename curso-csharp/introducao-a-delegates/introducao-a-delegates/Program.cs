using System;

namespace introducao_a_delegates
{
    internal class Program
    {
        delegate double BinaryNumericOperation(double n1, double n2);
            
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculateService.Max;
            double result = op(a, b);
            Console.WriteLine(result);
        }
    }
}
