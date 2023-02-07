using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_retangulo_orientacao_a_objetos
{
    class Retangulo
    {

        public double Largura;
        public double Altura;


        public double Area()
        {
            return Altura * Largura;
        }

        public double Perimentro()
        {
            return 2 * (Altura + Largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
