//Multicast delegates

//• Delegates que guardam a referência para mais de um método
//• Para adicionar uma referência, pode-se usar o operador +=
//• A chamada Invoke (ou sintaxe reduzida) executa todos os métodos na
//ordem em que foram adicionados
//• Seu uso faz sentido para métodos void

//using System;
//using System.Collections.Generic;
//using Course.Services;
//namespace Course
//{
//    delegate void BinaryNumericOperation(double n1, double n2);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            double a = 10;
//            double b = 12;

//            BinaryNumericOperation op = CalculationService.ShowSum;

//            op += CalculationService.ShowMax; // adicionou mais uma referência para outra função

//            op.Invoke(a, b); // retorna os 2 resultados das operações
//        }
//    }
//}


//Predicate(exemplo com RemoveAll)

//É um Delegate


//Predicate (System)
//• Representa um método que recebe um objeto do tipo T e retorna um valor booleano

//• https://msdn.microsoft.com/en-us/library/bfcke1bz%28v=vs.110%29.aspx

//public delegate bool Predicate<in T>(T obj);


//Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja 100.

//using System;
//using System.Security.Cryptography.X509Certificates;
//using Course.Entities;

//namespace Course
//{
//    delegate void BinaryNumericOperation(double n1, double n2);
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            List<Product> list = new List<Product>();
//            list.Add(new Product("Tv", 900.00));
//            list.Add(new Product("Mouse", 50.00));
//            list.Add(new Product("Tablet", 350.50));
//            list.Add(new Product("HD Case", 80.90));

//            //list.RemoveAll(p => p.Price >= 100.0);* Primeira forma: Lambda, Função anônima.

//            list.RemoveAll(ProductTest); // Segunda forma, Predicate (delegate): referência para uma função, o Predicate é uma sobrecarga do Método RemoveAll

//            foreach (Product p in list) 
//            {
//                Console.WriteLine(p);
//            }
//        }
//        public static bool ProductTest(Product p)
//        {
//            return p.Price >= 100.0;
//        }

//        // static: são funções que não dependem de nenhuma variável de instância, quando invocados executam uma função sem a dependência do conteúdo de um objeto ou a execução da instância de uma classe, conseguindo chamar direto qualquer método da classe e também manipulando alguns campos da classe
//    }
//}

// AULA 232 ---------------------------

// Action(System) - Delegate
//• Representa um método void que recebe zero ou mais argumentos

// https://msdn.microsoft.com/en-us/library/system.action%28v=vs.110%29.aspx

// Ex:
//public delegate void Action();
//public delegate void Action<in T>(T obj);
//public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
//public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
//(16 sobrecargas)


using System;
using System.Data;
using System.Diagnostics;
using Course.Entities;

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


            //PRIMEIRA FORMA: 

            //list.ForEach(UpdatePrice); // Sobrecarga, aceita Action

            //foreach(Product p  in list)
            //{
            //    Console.WriteLine(p);
            //}


            // SEGUNDA FORMA, DECLARANDO OBJETO ACTION:
            //Action<Product> act = UpdatePrice; // Referência p/ método


            // TERCEIRA FORMA - Lamba, no caso da action tem que ter abre e fecha chaves:
            //Action<Product> act = p => { 
            //    p.Price += p.Price * 0.1; 
            //};

            //list.ForEach(act);

            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}


            // QUARTA FORMA: Lambda inline:

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        //static void UpdatePrice(Product p)
        //{
        //    p.Price += p.Price * 0.1;
        //}
    }
}