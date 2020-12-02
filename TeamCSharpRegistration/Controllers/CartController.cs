using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace TeamCSharpRegistration.Controllers
{
    // Shanice - Setup controller for cart feature.

    // Shanice - Setup for fetching current user's ID.
    public class CartController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public CartController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult ViewCart(int sectionID)
        {
            // Shanice - Temporarily using for visual confirmation of data being sent to new view.
            ViewBag.userid = _userManager.GetUserId(HttpContext.User);
            return View(sectionID);
        }
    }
}