namespace Ex208.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; } // data de vencimento
        public double Amount { get; set; } // quantia


        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
    }
}