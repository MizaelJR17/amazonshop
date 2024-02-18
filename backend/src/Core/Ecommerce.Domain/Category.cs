using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Ecommerce.Domain.Common;

namespace Ecommerce.Domain
{
    public class Category : BaseDomainModel
    {
        [Column(TypeName = "NVARCHAR(100)")]
        public string Name { get; set; }

        public virtual ICollection<Product>? Products {get; set;}
    
    }
}