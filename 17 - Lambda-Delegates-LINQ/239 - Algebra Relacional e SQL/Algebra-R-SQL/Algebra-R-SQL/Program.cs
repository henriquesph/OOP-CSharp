﻿// Algebra Relacional e SQL
// Relacional - tabelas, chaves primárias e estrangeiras

//Operações básicas da álgebra relacional

// ---------------x-----------------

//• Produto cartesiano:
//resultado de 2 tabela: SELECT * FROM PRODUCT, CATEGORY (dados se repetem mesmo com chaves diferentes)

// ---------------x-----------------

//• Junção (produto cartesiano + restrição de chaves correspondentes (primária e estrangeira)
// SELECT * FROM PRODUCT, CATEGORY WHERE PRODUCT.CATEGORY_ID = CATEGORY.ID

// ou

//SELECT*
//FROM PRODUCT
//INNER JOIN CATEGORY cat
//ON PRODUCT.CATEGORY_ID = cat.ID

// ---------------x-----------------

//• Restrição: produto cartesiano - junção - restrição

//SELECT *
//FROM PRODUCT
//INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID
//WHERE CATEGORY.NAME = 'Computers'


//• Projeção - junção, mas com apenas as colunas informadas, não mostra todos os campos diferente da restrição


//SELECT PRODUCT.*, CATEGORY.NAME
//FROM PRODUCT
//INNER JOIN CATEGORY cat ON PRODUCT.CATEGORY_ID = cat.ID
//WHERE CATEGORY.NAME = 'Computers'


// ----------------------------------------------------------------------------

// 240 - : LINQ com notação similar a SQL


using System;
using System.Linq;
using Course.Entities;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Course
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection) 
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

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);
            // SINTAXE ALTERNATIVA
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0 // Restrição
                select p; // projeção
            Print("TIER 1 AND PRICE < 900:", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("NAMES OF PRODUCTS FROM TOOLS", r2);


            // var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };
            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);


            // var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name // Order inversa, primeiro ele vai ordenar por preço
                orderby p.Price
                select p;


            //var r5 = r4.Skip(2).Take(4); // pula 2 elementos e pega 4 elementos
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);

            //var r6 = products.First();
            //var r6 = products.FirstOrDefault();
            var r6 =
                (from p in products
                 select p).FirstOrDefault();
            Console.WriteLine("First test1: " + r6);



            // var r16 = products.GroupBy(p => p.Category); 
            var r16 =
                 from p in products
                 group p by p.Category;

            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}