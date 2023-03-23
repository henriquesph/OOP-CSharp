using System;
using seção10.Entities;
using System.Globalization;

namespace seção10
{
    class Program
    {
        static void Main(string[] args)
        { 
        //Demo: suponha que você queira:
        //• Totalizar o saldo de todas as contas.
        //• Sacar 10.00 de todas as contas. 

            List<Account> list = new List<Account>(); // lista não pode misturar vários tipo, mas nesse caso sim, pois a superclasse é do mesmo tipo

            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAcount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new SavingsAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list) {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.Withdraw(10.0); // faz a chamada dos métodos de maneira polimórfica, savings account tem a taxa de 2 reais
            }

            foreach (Account acc in list)
            {
                Console.WriteLine("Update Balance: "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
        }
    }
}

//Classes abstratas (no UML é escrito em itálico)

//• São classes que não podem ser instanciadas
//• É uma forma de garantir herança total: somente subclasses não
//abstratas podem ser instanciadas, mas nunca a superclasse abstrata



//Exemplo

//Suponha que em um negócio relacionado a banco, apenas
//contas poupança e contas para empresas são permitidas.
//Não existe conta comum.
//Para garantir que contas comuns não possam ser
//instanciadas, basta acrescentarmos a palavra "abstract" na
//declaração da classe.


//Questionamento

//• Se a classe Account não pode ser instanciada, por que
//simplesmente não criar somente SavingsAccount e
//BusinessAccount?
//• Resposta:
//• Reuso: mudando em 1 muda em todas, evita erros
//• Polimorfismo: a superclasse classe genérica nos permite
//tratar de forma fácil e uniforme todos os tipos de conta,
//inclusive com polimorfismo se for o caso (como fizemos nos
//últimos exercícios). Por exemplo, você pode colocar todos
//tipos de contas em uma mesma coleção.
