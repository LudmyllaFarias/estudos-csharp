﻿using System;


namespace membros_estaticos
{
    class Calculadora
    {
         public static double PI = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, 3.0);
        }

    }
}
