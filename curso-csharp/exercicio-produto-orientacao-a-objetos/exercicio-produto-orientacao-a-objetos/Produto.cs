using System.Globalization;

namespace exercicio_produto_orientacao_a_objetos
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        CultureInfo CI = CultureInfo.InvariantCulture;

        // Mais de uma construtor na mesma classe(sobrecarga)
        
        public Produto() { }

        public Produto(string name, double preco, int quantidade)
        {
            this.Nome = name;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }
        
        public double ValorTotalEmEstoque()
        {
            return this.Quantidade * Preco;
        }

        // Sobrecarga é ter dois ou mais métodos
        // com mesmo nome, mas, parametros diferentes.
        public int AdicionarProdutos(int quantidade)
        {
           return this.Quantidade += quantidade;
        }

        public int RemoverProdutos(int quantidade)
        {
            return this.Quantidade -= quantidade;
        }

        // Sobreposição
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CI);
        }


    }
}
