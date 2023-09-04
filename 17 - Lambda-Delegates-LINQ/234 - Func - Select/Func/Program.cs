//Func(System) - usando o Select (faz parte do linq, ver mais a frente)

//• Representa um método que recebe zero ou mais argumentos, e retorna um valor
// Diferente do Action, que não retorna nenhum valor

//• https://msdn.microsoft.com/en-us/library/bb534960%28v=vs.110%29.aspx

//public delegate TResult Func<out TResult>();
//public delegate TResult Func<in T, out TResult>(T obj);
//public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
//public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);

//(16 sobrecargas)

using System;
using Course.Entities;
using System.Collections.Generic;
using System.Linq; // para chamar a função Select

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            // Func - PRIMEIRA FORMA
            //List<string> result = list.Select(NameUpper).ToList(); // necessária a conversão em lista porque o Select é do tipo IEnumerable

            //foreach(string s in result)
            //{
            //    Console.WriteLine(s);
            //}


            // SEGUNDA FORMA
            // Delegate func que recebe um func e retorna uma string, recebendo a referência para o método NameUpper
            //Func<Product, string> func = NameUpper;

            //List<string> result = list.Select(func).ToList();

            //foreach (string s in result)
            //{
            //    Console.WriteLine(s);
            //}


            // TERCEIRA FORMA: LAMBDA - Comentei a última função

            // p = Product p
            Func<Product, string> func = p => p.Name.ToUpper(); // poderia usar chaves e o return, mas não é necessário, porque o func já retorna

            // outra forma de fazer é colocando a expressão lambda dentro do parâmetro
            List<string> result = list.Select(func).ToList();

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }

        }

        //static string NameUpper(Product p)
        //{
        //    return p.Name.ToUpper();
        //}
    }
}