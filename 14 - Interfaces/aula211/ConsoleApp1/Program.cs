// Interface Comparable


//public interface IComparable
//{
//    int CompareTo(object other); // devolve um método que diz se um objeto é menor, igual ou maior. (-1, 0, 1)
//}


//Console.WriteLine("maria".CompareTo("alex"));
//Console.WriteLine("alex".CompareTo("maria"));
//Console.WriteLine("maria".CompareTo("maria"));

//Output:
//1
//- 1
//0

//using System;
//using System.IO;
//using System.Collections.Generic;

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string path = @"c:\temp\in.txt"; // lista só com strings de nome

//            try
//            {
//                using (StreamReader sr = File.OpenText(path))
//                {
//                    List<string> list = new List<string>();
//                    while (!sr.EndOfStream)
//                    {
//                        list.Add(sr.ReadLine());
//                    }
//                    list.Sort(); // ordena a lista
//                    foreach(string str in list)
//                    {
//                        Console.WriteLine(str);
//                    }
//                }
//            }
//            catch (IOException e)
//            {
//                Console.WriteLine("An error ocurred");
//                Console.WriteLine(e.Message);
//            }
//        }
//    }
//}

// Segundo exemplo, nome + Salario (arquivo csv)

using System;
using System.IO;
using System.Collections.Generic;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\in2.txt"; // lista só com strings de nome

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); // Faz uso da Interface IComparable
                    // Define qual argumento deve ser comparado na classe Employee utilizando a interface Icomparable
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}