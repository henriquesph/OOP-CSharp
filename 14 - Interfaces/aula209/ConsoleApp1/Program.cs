//Herdar vs.cumprir contrato]

//Aspectos em comum entre herança e interfaces
//• Relação é-um
//• Generalização/especialização
//• Polimorfismo


//Diferença fundamental
//• Herança => reuso
//• Interface => contrato a ser cumprido

using ConsoleApp1.Model.Entities;
using ConsoleApp1.Model.Enums;

// Uso de Interface (define o contrato) e a Classe Abstrata (define a cor (reuso) - Ver diagrama UML (segundo exemplo)

//E se eu precisar implementar Shape como interface, porém também quiser
//definir uma estrutura comum reutilizável para todas figuras?

// Nesse caso posso escolher herdar da interface (não preciso usar os atributos)
// ou herdar da classe abstrata, aí eu herdo os atributos

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle()
            {
                Radius = 2.0,
                Color = Color.Write
            };

            IShape s2 = new Rectangle()
            {
                Width = 3.5,
                Height = 4.0,
                Color = Color.Black
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}