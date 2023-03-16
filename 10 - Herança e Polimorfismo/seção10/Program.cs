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
            BusinessAcount acount = new BusinessAcount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(acount.Balance);
            // acount.Balance = 200.0; não tem como modificar porque Balance é protected
        }
    }
}


