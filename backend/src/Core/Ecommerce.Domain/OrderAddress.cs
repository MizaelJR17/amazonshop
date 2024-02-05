using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class OrderAddress : BaseDomainModel
    {
        public string? Address { get; set; }

        public string? City { get; set; }
    
        public string? Department { get; set; }
    
        public string? PostalCode { get; set; }

        public string? Username { get; set; }

        public string? Country { get; set; }
    }
}