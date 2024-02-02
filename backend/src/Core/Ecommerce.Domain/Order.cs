using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Order : BaseDomainModel
    {
        public Product? Product { get; set; }
        public int ProductId { get; set; }
    }
}