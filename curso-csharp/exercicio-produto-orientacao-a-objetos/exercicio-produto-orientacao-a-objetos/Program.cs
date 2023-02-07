using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace exercicio_produto_orientacao_a_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Entre com os dados do produto: ");

            Console.Write("Nome:");
            string nome = Console.ReadLine();
            Console.Write("Preço:");
            double preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque:");
            int qtdProduto = int.Parse(Console.ReadLine());

            // Instancia produto
            Produto produto = new Produto(nome, preco, qtdProduto);

            Console.Write("Dados do produto: " + produto);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionando ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.Write("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidade);

            Console.Write("Dados atualizados: " + produto);
            Console.WriteLine();

            Console.Read();
        }
    }
}
