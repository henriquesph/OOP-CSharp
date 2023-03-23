//métodos ABSTRATOS

//• São métodos que não possuem implementação.
//• Métodos precisam ser abstratos quando a classe
//é genérica demais para conter sua
//implementação.
//• Se uma classe possuir pelo menos um método
//abstrato, então esta classe também é abstrata.
//• Notação UML: itálico
//• Ao criar um lista (tem que ser do mesmo tipo), consegue-se instanciar objetos diversos tipos de objetos que são subclasses

// EXERCÍCIO 145

using Metodos_Abs.Entities;
using Metodos_Abs.Entities.Enums;
using System.Globalization;

namespace Metodos_Abs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Enter the number of Shapes");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i<=n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                
                Console.Write("Rectangle or Circle (r/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Color (Black/Blue/Red: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                    Console.Write("Height");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                    list.Add(new Rectangle(width, height, color));
                }
                if (ch == 'c')
                {
                    Console.Write("Radius");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("SHAPE AREAS");

            foreach(Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            
        }
    }
}