using System.Globalization;
namespace Course
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        /* Construtores = instanciação obrigatória */
        public Produto (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }


        /* Sobrecarga - Mesmo método com diferentes construtores aceitando parametros diferentes */

        //public Produto (String nome, double preco) // aceitando apenas 2 parâmetros
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = 5; // por padrão se não colocasse nada seria 0, mas poderia iniciar com qualquer valor
        //}

        public Produto() // Construtor padrão - como foi utilizada a sobrecarga é preciso declarar o padrão
        {

        }

        public Produto(int quantidade)
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this() // referencia o construtor acima - pega o parâmetro quantidade
        {
            Nome = nome;
            Preco = preco;
        }

        //public Produto(string nome, double preco, int quantidade) : this(nome, preco) // passa o parâmetro do construtor acima - verificar o erro
        //{
        //    Quantidade = quantidade;
        //}
        

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}