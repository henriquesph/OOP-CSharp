using ConsoleApp1.Model.Enums;

namespace ConsoleApp1.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area(); // Implementação da Interface
    }
}
