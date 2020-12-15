using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamCSharpRegistration.Data;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Controllers
{
    public class EnrollingController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private RegistrationDbContext context { get; set; }

        public EnrollingController(RegistrationDbContext ctx, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            context = ctx;
        }
        public IActionResult EnrolledClasses(string actionType)
        {
            string userID = _userManager.GetUserId(HttpContext.User);

            if (actionType == "enroll")
            {

                List<CartItem> cartItems = new List<CartItem>();

                cartItems = context.CartItems
                    .Where(c => c.UserId == userID)
                    .ToList();

                foreach (CartItem c in cartItems)
                {

                }




                return View();
            }
            else
            {
                return View();
            }


            
        }
    }
}