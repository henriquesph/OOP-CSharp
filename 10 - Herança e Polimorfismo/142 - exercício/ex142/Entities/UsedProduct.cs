using System.Globalization;

namespace ex142.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct() {
        }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }

        public override string PriceTag()
        {
            return Name
                + "(used) $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + (" Manufature Date: ")
                + ManufatureDate.ToString("dd/MM/yyyy");
        }
    }
}
