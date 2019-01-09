using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models.Entities
{
    public class MagicUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
