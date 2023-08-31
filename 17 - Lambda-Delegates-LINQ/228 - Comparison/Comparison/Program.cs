// IComparable viola os princípios SOLID - ocp - se mudar o parâmetro de comparação, tem que mudar na classe Product, no Comparison não

// Expressão Lambda: função anônima, não precisa ser declarada

using System;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Comparison é um delegate

            // Referência de método como parâmentro
            /*list.Sort(CompareProducts); */// Delegate: Passou uma referência para função com Type Safety??


            // Outra forma de fazer - Referência de método atribuído a uma variável tipo delegate
            //Comparison<Product> comp = CompareProducts; // variável que guarda a referência para função para depois ser usada como argumento da função sort
            //list.Sort(comp);

            //foreach(Product p in list)
            //{
            //    Console.WriteLine(p);
            //}

            //static int CompareProducts(Product p1, Product p2)
            //{
            //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
            //}



            // LAMBDA:
            // (p1, p2): argumento da função, não precisa dizer o tipo, ele é inferido (no caso é um Product)
            // => : Operador de função, em seguida é colocado a expressão resultante dos 2 argumentos

            // lambda atribuída a uma variável do tipo delegate
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            //list.Sort(comp);
            // ou

            // Lambda inline
            list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}