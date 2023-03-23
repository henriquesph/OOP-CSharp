using Metodos_Abs.Entities.Enums;

namespace Metodos_Abs.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)  
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius; // pi * raio²
        }
    }
}
