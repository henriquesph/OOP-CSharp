// utilidade: caso um projeto mude de requisito tem essa opção, ex: Caminhonete que mudou de categoria e agora é definida como carro

//• Upcasting
//• Casting da subclasse para superclasse
//• Uso comum: polimorfismo

//• Downcasting
//• Casting da superclasse para subclasse
//• Palavra as  // sintaxe alternativa de casting
//• Palavra is  // se x É y faça alguma coisa...
//• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)  ?

namespace seção10.Entities
{
    class SavingsAccount : Account // conta poupaça
    {
        public double InterestRate { get; set; } //taxa de juros

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }

}
