using Order.Entities.Enums;
using Order.Entities;
using System.Globalization;

namespace Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, date);


            Console.WriteLine("Enter Order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            DateTime moment = DateTime.Now;

            Orders order1 = new Orders(moment, status, client);

            Console.Write("How many items to this order?");
            int nItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= nItems; i++) {
                Console.WriteLine("Enter #" + i + " item data:");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();

                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem item = new OrderItem(quantity, prodPrice, product);
                order1.AddItem(item);
            }

            Console.WriteLine(order1);
        }
    }
}