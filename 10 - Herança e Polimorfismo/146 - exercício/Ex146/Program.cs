using Ex146.Entities;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Ex146
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas= new List<Pessoa>();

            Console.Write("Enter the number of tax payers ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax player #{i} data:");

                Console.WriteLine("Individual or Company (i/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Anual Income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'i')
                {
                    Console.Write("Helth expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else if (ch == 'c') {
                    Console.Write("Number of Employers");
                    int numEmployer = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoJuridica(nome, rendaAnual, numEmployer));
                }
            }

            Console.WriteLine("TAXES PAID:");

            double sum = 0;
            foreach(Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + "$" + p.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                sum += p.Imposto();
            }

            Console.WriteLine("TOTAL TAXES: $:" + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}