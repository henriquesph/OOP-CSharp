using System;
using ExComposicao.Entities;
using ExComposicao.Entities.Enums;
using System.Globalization;

namespace ExComposicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            
            Console.WriteLine("Nome: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior / MidLevel / Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Instanciação de objetos
            Department dept = new Department(deptName); // sobrecarga do construtor: diversas versões do construtor dentro de uma classe - no caso usei a segunda versão
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How may contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: "); // $ - interpolação - para pegar o valor da variável

                Console.Write("Date: (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income: (MM/YYYY: ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name); // acessa o departamento antes depois a propriedade Name
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}