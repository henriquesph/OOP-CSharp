using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seção_9.Entities.Enums // Criando um Enum
{
    enum OrderStatus : int // Herança de tipos - ver mais
    {
        PendingPayment = 0, // Constantes
        Processing = 1, // se não atribuir um valor por padrão ele começa a atribuir do zero em diante
        Shipped = 2,
        Delivered = 3
    }
}
