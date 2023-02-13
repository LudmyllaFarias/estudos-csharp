using System;
using System.Collections.Generic;
using System.Text;

namespace introducao_a_delegates
{
    internal class CalculateService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}
