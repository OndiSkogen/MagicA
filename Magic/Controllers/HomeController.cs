using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magic.Models.Entities;
using Magic.Models.Services;
using Microsoft.AspNetCore.Mvc;

namespace Magic.Controllers
{
    public class HomeController : Controller
    {
        HomeService service;

        public HomeController(HomeService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            service.CreateDb();
            return View();
        }
    }
}