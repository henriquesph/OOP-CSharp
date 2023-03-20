using ex142.Entities;
using System.Globalization;

namespace ex142
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of Product:");
            int n = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>(); 

            for(int count = 1; count <= n; count++)
            {
                Console.WriteLine("Product #" + count + " data");

                Console.Write("Common, used or imported (c/u/i): ");
                char tipo = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tipo == 'u')
                {
                    Console.Write("Manufacture data (DD/MM/YYYY): ");
                    DateTime manufatureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufatureDate));
                }

                else if(tipo == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(tipo == 'c')
                {
                    products.Add(new Product(name, price));
                }
            }
            Console.WriteLine();

            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}


