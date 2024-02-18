using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Configuration
{
    public class OrderItemConfiguration
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.Property(x => x.Precio).HasColumnType("decimal(10,2)");
        }
    }
}