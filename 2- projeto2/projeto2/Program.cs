using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Produto p = new Produto(nome, preco, quantidade); /* Construtor passando os parâmetros obrigatórios */

            Produto p2 = new Produto(nome, preco); // construtor com 2 parâmetros (sobrecarga)

            Produto p3 = new Produto();  // Construtor padrão

            Produto p4 = new Produto() // Declarando propriedades dentro do construtor - tem que ter o construtor padrão definido na classe
            {
                Nome = "Geladeira",
                Preco = 500,
                Quantidade = 2
            };

            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}