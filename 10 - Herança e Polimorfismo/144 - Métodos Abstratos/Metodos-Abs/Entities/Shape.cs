using Metodos_Abs.Entities.Enums;

namespace Metodos_Abs.Entities
{
    abstract class Shape // se tiver método abstrado a classe também tem que ser abstrata
    {
        public Color Color { get; set; }

        //public Shape() // não usei o construtor padrão para obrigar a todas as prorpriedades serem instanciadas
        //{

        //}

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); // Declaração de método abstrato / não precisa usar o virtual, ele já obriga o método a ser implementado na subclasse
    }
}
