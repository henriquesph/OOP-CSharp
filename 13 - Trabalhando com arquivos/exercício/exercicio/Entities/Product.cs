using System.Xml.Schema;

namespace exercicio.Entities
{
    class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(String name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
    }
}
