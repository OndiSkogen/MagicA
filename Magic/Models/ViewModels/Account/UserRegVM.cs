using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Magic.Models.ViewModels.Account
{
    public class UserRegVM
    {
        [Required]
        [MinLength(5)]
        public string UserName { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
