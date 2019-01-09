using Magic.Models.Entities;
using Magic.Models.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models.Services
{
    public class AccountService
    {
        UserManager<MagicUser> userManager;
        SignInManager<MagicUser> signInManager;
        RoleManager<MagicUser> roleManager;

        public AccountService(UserManager<MagicUser> userManager, SignInManager<MagicUser> signInManager, RoleManager<MagicUser> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        //public async Task<IdentityResult> CreateUserAsync(UserRegVM user)
        //{
        //    MagicUser mUser = new MagicUser();

        //    mUser.Email = user.Email;
        //    mUser.UserName = user.UserName;
        //    mUser.PasswordHash = user.Password;

        //    var createResult = await userManager.CreateAsync(mUser);

        //    return createResult;
        //}
    }
}
