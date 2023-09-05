using System;
using System.Linq;
using Course.Entities;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection) // IEnumerable - para ser compatível com o tipo linq
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 3, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            Print("TIER 1 AND PRICE < 900:", r1);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            // Objeto anônimo, não está declarado em nenhuma das classes
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name}); // CategoryName é um alias, para não ter 2 alias e acusar erro do compilador
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); // ordenando por 2 predicados

            var r5 = r4.Skip(2).Take(4); // pula 2 elementos e pega 4 elementos

            //var r6 = products.First();
            var r6 = products.FirstOrDefault(); // se encontrar um lista vazia retorna Null, diferente do First que dá erro.
            Console.WriteLine("First test1: " + r6);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); // pega 1 elemento com esse predicado do tipo Product, se nao tivesse SingleOrDefault retornaria objeto do tipo IEnumerable<Product>
            // Caso retorne mais de um elemento ocorre uma exceção
            // caso não retorne nenhum valor retorna nulo, diferente do sigle que dá exceção
            Console.WriteLine("Single or Default test1: " + r8);


            // 238 - PARTE 2
            // OPERAÇÕES DE AGREGAÇÃO

            var r10 = products.Max(p => p.Price); // o Predicado implementa o IComparable
            Console.WriteLine("Max Price: " + r10);

            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 sum prices: " + r12);

            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Category 1 Average prices: " + r13); // se não tiver elementos dá erro (divisão por zero)

            // Corrigindo o erro acima
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // se estiver vazio passa o zero
            Console.WriteLine("Category 5 Average prices: " + r14);
        }   
    }
}
5:30