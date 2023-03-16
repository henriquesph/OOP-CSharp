namespace seção10.Entities
{
    class Account
    {
        public int Number { get; private set; } // private: encapsulamento (pode ser acessado, mas não modificado por outras classes)
        public string Holder { get; private set; }
        public double Balance { get; protected set; } // mesma coisa que o private, com a diferença que pode ser alterado por sua subclasse, além da classe principal

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) // saque
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
