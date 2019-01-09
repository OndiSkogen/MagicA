using Magic.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models.Services
{
    public class HomeService
    {
        MagicUserContext ctx;

        public HomeService(MagicUserContext ctx)
        {
            this.ctx = ctx;
        }

        public void CreateDb()
        {
            ctx.Database.EnsureCreated();
        }
    }
}
