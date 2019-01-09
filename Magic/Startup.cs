using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magic.Models.Entities;
using Magic.Models.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Magic
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o => o.LoginPath = "/Account/Login");
            var connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Magic;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<MagicUserContext>(o =>
            o.UseSqlServer(connString));

            services.AddIdentity<MagicUser, IdentityRole>()
                .AddEntityFrameworkStores<MagicUserContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
            services.AddTransient<HomeService>();
            services.AddTransient<AccountService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
        }
    }
}
