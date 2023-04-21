using System;
using Seção_9.Entities.Enums;

namespace Seção_9.Entities
{
    class Order // Entidade Pedido
    {
        public int Id { get; set; } // properties
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
