using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ConsoleApp1.Entities;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    
                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine("Enter Salary");
            double baseSalary = double.Parse(Console.ReadLine());

            var biggerSalary = list.Where(p => p.Salary > baseSalary).OrderBy(p => p.Email).Select(p => p.Email);

            Console.WriteLine("Email of people whose salary is more than" + baseSalary);

            foreach (string lEmail in biggerSalary)
            {
                Console.WriteLine(lEmail);
            }

            double sum = 0.0;
            var lSalary = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary);

            foreach(double sal in lSalary)
            {
                sum += sal;
            }
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
        }
    }
}