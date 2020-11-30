using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TeamCSharpRegistration.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public CartController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult ViewCart()
        {
            return View();
        }
    }
}