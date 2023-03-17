// HERANÇA - Inheritance

// É um tipo de associação que permite que uma classe herde dados e
//comportamentos de outra (atributos e métodos)

//Vantagens
//• Reuso
//• Polimorfismo - ?

// : (estende)
// base (referência para a superclasse)

// RELAÇÃO:
// herança: é um (ex - uma conta bancária especial (subClasse) também É uma conta comum (superclasse) -> generalização e especialização
// - extensão: conta comum especial extende da conta comum

// ** composição: tem um ou tem vários (ex: um trabalhador tem contratos)

// Herança é uma associação entre classes e não entre objetos (na composição se estanciava mais de um objeto, ex: objeto trabalhador associado com objeto departamento, na herança se estancia um único objeto com todos os dados, no caso a conta bancária especial já tendo os dados da comum

using System;
using seção10.Entities;

namespace seção10
{
    class Program
    {
        static void Main(string[] args)
        {
            // INÍCIO HERANÇA

            //BusinessAcount acount = new BusinessAcount(8010, "Bob Brown", 100.0, 500.0);

            //Console.WriteLine(acount.Balance);
            // acount.Balance = 200.0; não tem como modificar porque Balance é protected

            // FIM HERANÇA

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAcount bacc = new BusinessAcount(1002, "Maria", 0.0, 500.0);

            // UPCASTING
            Account acc1 = bacc; // aceita, porque uma subclasse BusinessAcount é uma superclasse Account
            Account acc2 = new BusinessAcount(1003, "Bob", 0.0, 200.0); // subclasse atribuida a uma variável do tipo superclasse
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            // DOWNCASTING - operação insegura, validade antes (ver IF)
            BusinessAcount acc4 = (BusinessAcount)acc2; // mesmo o acc2 sendo atribuída com uma subclasse, o compilador entende o tipo da varíavel que é uma superclasse, tem que fazer o casting.
            acc4.Loan(100.0); // consegue acessar método de empréstimo do businessAccount
            //acc2.Loan(100.0); dá erro, compilador não consegue acessar, apesar de ter sido instanciada como uma subclasse businessAccount, o tipo da variavel é uma superclasse Account, que não tem esse método, tem que fazer o downcasting, como na variável acima
            /*BusinessAcount acc5 = (BusinessAcount)acc3;*/ // o compilador não consegue prever esse erro, só dá erro em tempo de execução, apesar das 2 serem subclasses, Business Account e SavingsAccount não são compatíveis, não são do mesmo tipo (Ver na UML que as 2 herdam da superclasse Account em comum
            if(acc3 is BusinessAcount) // para evitar o erro acima, tem que testar, como não é do mesmo tipo, não será instanciado
            {
                //BusinessAcount acc5 = (BusinessAcount)(acc3);
                BusinessAcount acc5 = acc3 as BusinessAcount; // AS - sintaxe alternativa de casting.
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            if (acc3 is SavingsAccount) // vai entrar nessa condição, pq é do mesmo tipo
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update");

            }

        }
    }
}

//• Upcasting
//• Casting da subclasse para superclasse
//• Uso comum: polimorfismo

//• Downcasting
//• Casting da superclasse para subclasse
//• Palavra as   ?
//• Palavra is   ?
//• Uso comum: métodos que recebem parâmetros genéricos (ex: Equals)  ?
