namespace Interface.Services
{
    //class BrazilTaxService
    class BrazilTaxService : ITaxService // mesmo símbolo de herança mas não é. É a realização de uma interface
    {
        public double Tax (double amount) // mesmo método da interface
        {
            if(amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
