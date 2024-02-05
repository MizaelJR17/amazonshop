using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Order : BaseDomainModel
    {
        public string? CompradorNombre { get; set; }
    
        public string? CompradorUserName { get; set; }
    
        public OrderAddress? OrderAddress { get; set; }
    
        public IReadOnlyList<OrderItem>? OrderItems { get; set; }
        
        [Column(TypeName ="decimal(10,2)")]
        public decimal Subtotal { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        [Column(TypeName ="decimal(10,2)")]
        public decimal Total { get; set; }
        
        [Column(TypeName ="decimal(10,2)")]
        public decimal Impuesto  { get; set; }

        [Column(TypeName ="decimal(10,2)")]
        public decimal PrecioEnvio { get; set; }

    }

}