using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models.Entities
{
    public class MagicUserContext : IdentityDbContext<MagicUser>
    {
        public MagicUserContext(DbContextOptions<MagicUserContext> options) : base(options)
        {
            // Create DB schema (only works against an empty database)            
            Database.EnsureCreated();
        }
    }
}
