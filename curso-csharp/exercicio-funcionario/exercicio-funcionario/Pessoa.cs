using System;
using System.Globalization;


namespace exercicio_funcionario
{
    class Pessoa
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
           return SalarioBruto - Imposto;
        }

        public double AumentatSalario(double porcentagen)
        {
            return SalarioBruto = SalarioBruto + (SalarioBruto * porcentagen / 100.00);
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
