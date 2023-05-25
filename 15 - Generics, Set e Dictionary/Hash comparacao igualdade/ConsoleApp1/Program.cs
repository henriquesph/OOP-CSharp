//Como as coleções Hash testam igualdade?

//• Se GetHashCode e Equals estiverem implementados: 
//• Primeiro GetHashCode. Se der igual, usa Equals para confirmar. 

//• Se GetHashCode e Equals NÃO estiverem implementados: 
//• Tipos referência: compara as referências dos objetos // onde está na memória
//• Tipos valor: comparar os valores dos atributos (struct: compara pelos valores dos atributos)

using ConsoleApp1.Entities;
using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // string pq implementa equals e gethashCode
            HashSet<string> set = new HashSet<string>();
            set.Add("Maria");
            set.Add("Alex");

            //Console.WriteLine(set.Contains("Maria")); // True


            // Quando não implementa equals e gethashcode

            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));


            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); // aponta para outro endereço de memória, referência do endereço guardado na variável prod
            Console.WriteLine(a.Contains(prod)); // False - Tipo referênica compara as referências dos objetos, 2 objetos diferentes ( GetHashCode e Equals não estavam implementados)

            // True: quando implementei o equals e hashCode no Product que comparei os conteúdos

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); // True: mesmo sem implementar equals e hashCode ele compara o valor

        }

    }
}