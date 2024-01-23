using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Product : BaseDomainModel 
    {
        public string? Name {get; set;}

        public decimal Price { get; set; }
        
        public string? Description { get; set; }
    }
}