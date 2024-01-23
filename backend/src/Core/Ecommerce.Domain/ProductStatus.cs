using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Ecommerce.Domain
{
    public enum ProductStatus
    {
        [EnumMember(Value ="Produto Inativo")]
        Inactivo,
        [EnumMember(Value ="Produto Inativo")]
        Activo
    }
}