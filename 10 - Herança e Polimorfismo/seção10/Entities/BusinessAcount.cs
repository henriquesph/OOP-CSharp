namespace seção10.Entities
{
    class BusinessAcount : Account // Herda ou extende o tipo Account
    {
        public double LoanLimit { get; set; } // limite para empréstimo

        public BusinessAcount()
        {
        }

        public BusinessAcount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) // aproveita o construtor da classe base
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount) // empréstimo
        {
            if (amount <= LoanLimit)
            {
                Balance += amount; // Balance - atributo da classe base
            }
        }
    }
}
