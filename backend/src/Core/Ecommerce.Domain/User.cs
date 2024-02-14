using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Ecommerce.Domain
{
    public class User : IdentityUser
    {
        public string? Name { get; set; }
    
        public string? Apelido { get; set; }

        public string? Phone { get; set; }

        public string? AvatarUrl { get; set; }
    
        public bool IsActive { get; set; }
    }

}