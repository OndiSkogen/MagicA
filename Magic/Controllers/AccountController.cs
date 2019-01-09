using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magic.Models.Services;
using Magic.Models.ViewModels.Account;
using Microsoft.AspNetCore.Mvc;

namespace Magic.Controllers
{
    public class AccountController : Controller
    {
        AccountService service;

        public AccountController(AccountService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[Route("account/register")]
        //public IActionResult UserReg()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<IActionResult> CreateUser(UserRegVM user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(nameof(UserReg), user);
        //    }

        //    var createResult = await service.CreateUserAsync(user);

        //    if (!createResult.Succeeded)
        //    {
        //        return View(nameof(UserReg), user);
        //    }

        //    return RedirectToAction("Index", "Home");
        //}
    }
}