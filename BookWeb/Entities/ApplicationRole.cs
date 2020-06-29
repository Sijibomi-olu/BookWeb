using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookWeb.Entities
{
    public class ApplicationRole : IdentityRole
    {
        public String RoleName { get; set; }
    }
}
