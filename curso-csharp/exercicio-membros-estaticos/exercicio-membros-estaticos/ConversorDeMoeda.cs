using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_membros_estaticos
{
    class ConversorDeMoeda
    {

        public static double ValorPagoEmReais(double valor, double cotacaoDolar)
        {
            return (valor * cotacaoDolar);
        }
    }
}
