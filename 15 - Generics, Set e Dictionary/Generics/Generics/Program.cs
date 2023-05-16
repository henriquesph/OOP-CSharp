//Generics permitem que classes, interfaces e métodos possam ser
//parametrizados por tipo. Seus benefícios são:

//• Reuso: Tipo genérico é definido na classe, quando foi instanciar e declarar se informa o tipo

//• Type safety - erro no tempo de execução no tipo (usando object que aceita qualquer tipo, o compilador não acusará o erro, por isso é recomendável utilizar o tipo genérico)

//• Performance - não precisa fazer boxing unboxing  - boxing é o processo de conversão de um tipo de valor para o tipo object

//• Uso comum: coleções (As coleções fornecem uma maneira mais flexível de trabalhar com grupos de objetos)

// coleção é uma classe, portanto você deve declarar uma instância da classe antes de adicionar elementos a essa coleção.

// <T> : Tipo genérico, pode ser qualquer letra
// O tipo será definido na hora de declarar e instanciar o tipo

//List<string> list = new List<string>();
//list.Add("Maria");
//string name = list[0];


using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How many values?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            printService.Print();
            Console.WriteLine("");
            Console.WriteLine("First: " + printService.First());
        }
    }
}