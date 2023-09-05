using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //Console.WriteLine(p.GetNome());

            //p.SetNome("TV 4K");

            //Console.WriteLine(p.GetNome());

            p.Nome = "TV 4k"; // implementação do propertie
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            //Console.WriteLine(p.GetPreco());
            //Console.WriteLine(p.GetQuantidade());
        }
    }
}