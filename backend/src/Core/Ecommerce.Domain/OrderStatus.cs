using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public enum OrderStatus
    {
        [EnumMember(Value = "Pendente")]
        Pending, 
        [EnumMember(Value = "O pagamento foi Recebido")]
        Completed,
        [EnumMember(Value = "O produto foi enviado")]
        Enviado,
        [EnumMember(Value = "Pendente")]
        Error
    }
}