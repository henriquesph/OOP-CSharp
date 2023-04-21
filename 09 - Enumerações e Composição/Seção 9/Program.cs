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


// COMPOSIÇÃO
// É um tipo de associação que permite que um objeto contenha outro
// Relação "tem-um" ou "tem-vários"
// Organização: divisão de responsabilidades
// Coesão - Cada objeto tem UMA responsabilidade
// Flexibilidade
// Reuso

// embora o símbolo UML para composição (todo-parte) seja o diamante
// preto, neste contexto estamos chamando de composição qualquer associação
// tipo "tem-um" e "tem-muitos".