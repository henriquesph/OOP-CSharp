//GetHashCode e Equals

//• São operações da classe Object utilizadas para comparar se um objetoé igual a outro
//• Equals: lento, resposta 100 %
//• GetHashCode: rápido, porém resposta positiva não é 100%• Os tipos pré-definidos (int, double...) já possuem implementação para essasoperações. Classes e structs personalizados precisam sobrepô-las. (ex: class Product)


//Equals
//Método que compara se o objeto é igual a outro, retornando
//true ou false


//string a = "Maria";
//string b = "Alex";
//Console.WriteLine(a.Equals(b)); // false


//GetHashCode
//Método que retorna um número inteiro representando um código gerado
//a partir das informações do objeto (a cada execução é gerado um número diferente)

//string c = "Maria";
//string d = "Alex";
//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());


//Regra de ouro do GetHashCode

//• Se o código de dois objetos for diferente, então os dois objetos são
//diferentes

//• Se o código de dois objetos for igual, muito provavelmente os objetos
//são iguais (pode haver colisão - por concidència gerar mesmo número)


// APLICAÇÃO: Varrer uma lista grande com getHashCode (mais rápido), quando encontrar o que procura validadar com o equals (é mais lento, mas só foi executado 1 vez)

using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com"};
            Client b = new Client { Name = "Alex", Email = "maria@gmail.com"};

            Console.WriteLine(a.Equals(b)); // True (email igual, compara o conteúdo)
            Console.WriteLine(a == b); // False = compara a referência do ponteiro de memória do objeto, se nome e email fossem iguais continuaria como false
        }
    }
}
