// Enumerações(enum)

//- tipo especial que serve para especificar de forma literal um conjunto
//de constantes relacionadas

//- tipo valor

//- Vantagem: melhor semântica, código mais legível e auxiliado pelo
//compilador

using Seção_9.Entities;
using Seção_9.Entities.Enums;
using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // Transformando enum em string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); // Transformando string em enum
            Console.WriteLine(os);
        }
    }
}