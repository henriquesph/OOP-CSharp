using System.Globalization;

namespace ConsoleApp1.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string cvsEmployee)
        {
            string[] vect = cvsEmployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) // Implementando a Interface IComarable para resolver o problema de ordenamento, decidir qual é o critério, se é pela ordem alfabética do nome ou do valor do salário
        {
            if (!(obj is Employee)) // programação defensiva - testar se é do tipo certo
            {
                throw new ArgumentException("Comparing error: argument is not Employee");
            }
            Employee other = obj as Employee; // DownCasting
            return Name.CompareTo(other.Name); // compareTo da classe string que já tem essa interface implementada
        }
    }
}