// utilidade: caso um projeto mude de requisito tem essa opção, ex: Caminhonete que mudou de categoria e agora é definida como carro

//• Upcasting
//• Casting da subclasse para superclasse
//• Uso comum: polimorfismo

//• Downcasting
//• Casting da superclasse para subclasse
//• Palavra as  // sintaxe alternativa de casting
//• Palavra is  // se x É y faça alguma coisa...
//• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)  ?

using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;

namespace seção10.Entities
{
    sealed class SavingsAccount : Account // conta poupaça
        // CLASSES E MÉTODOS SELADOS
        // SEAlED - classe selada, nao pode ser herdada

        // Segurança: dependendo das regras do negócio, às vezes é desejável
        // garantir que uma classe não seja herdada, ou que um método não
        // seja sobreposto.
        
        // Geralmente convém selar métodos sobrepostos, pois sobreposições múltiplas
        //podem ser uma porta de entrada para inconsistências, controle do código
        
        // Performance: atributos de tipo de uma classe selada são analisados
        // de forma mais rápida em tempo de execução.
        // • Exemplo: método que avalia a estrutura, se tiver o selead, ele termina a busca
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

        // SOBREPOSIÇÃO OU SOBRESCRITA: sobrescreveu o método da classe principal Account (virtual)

        //public override void Withdraw(double amount)
        //{
        //    Balance -= amount;
        //}



        // BASE: É possível chamar a implementação da superclasse
        // Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque normalmente da superclasse(Account), e depois descontar mais 2.0. Aproveita a superclasse e acrescenta algo

        // outro uso do BASE é o reaproveitamento do parâmetros nos construtores

        public sealed override void Withdraw(double amount) // evita que um método sobreposto possa ser sobreposto novamente. Só pode ser aplicado a métodos sobrepostos
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }

}
