// Restrições para Generics

//Restrições possíveis

//• https://docs.microsoft.com/en-us/dotnet/csharp/programmingguide/generics/constraints-on-type-parameters

//• where T: struct • where T : class
//• where T : unmanaged
//• where T : new() • where T : < base type name>
//• where T : U

using System;
using System.Collections.Generic;
using System.Globalization;
using Aula215.Entities;
using Aula215.Services;

// <T> Generics pode ser método, classe ou interface

namespace Aula215
{
    class Program
    {
        static void Main(string[] args)
        {
            /*List<int> list = new List<int>();*/ // int implementa a Interface Icomparable (ctrl + clique)
            List<Product> list = new List<Product>(); 

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(name, price));
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(list);

            Console.WriteLine("Max: ");
            Console.WriteLine(max);
        }
    }
}