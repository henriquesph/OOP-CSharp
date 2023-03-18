using ex140.Entities;
using System.Globalization;

namespace ex140
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employes");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int count = 1; count <= n; count++) {
                Console.WriteLine("Employee #" + count + " data:");

                Console.WriteLine("Outsourced (y/n)?");
                char res = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per Hour: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (res == 'n')
                {

                    Employee employee = new Employee(name, hours, valueHour);
                    employees.Add(employee);
                }
                else if (res == 'y')
                {
                    Console.WriteLine("Additional charge");
                    double additional = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Employee employee = new OutsourceEmployee(name, hours, valueHour, additional);
                    employees.Add(employee);
                }
                Console.WriteLine();
            }

            Console.WriteLine("PAYMENTS");

            foreach(Employee emp in employees)
            {
                Console.WriteLine(emp.Name + "-" + " $" + emp.Payment(),"F2",CultureInfo.InvariantCulture);
            }
        }
    }
}