using Ex155.Entities.Exeptions;

namespace Ex155.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {

            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(WithDrawLimit < amount)
            {
                throw new DomainExeptions("The amount exceeds withdraw limit");
            }
            if(Balance < amount)
            {
                throw new DomainExeptions("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
