using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TeamCSharpRegistration.Data;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Controllers
{
    // Shanice - Setup controller for cart feature.

    // Shanice - Setup for fetching current user's ID.
    public class CartController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private RegistrationDbContext context { get; set; }

        public CartController(RegistrationDbContext ctx, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            context = ctx;
        }

      
        [Authorize]
        public IActionResult ViewCart(int sectionID)
        {
            // Shanice - Complete backend for add to cart feature.
            string userID = _userManager.GetUserId(HttpContext.User);
            ViewBag.sectionId = sectionID;

            List<CartItem> initialCartItems = new List<CartItem>();

            initialCartItems = context.CartItems
                .Where(c => c.UserId == userID)
                .Where(s => s.SectionID == sectionID)
                .ToList();

            if (initialCartItems.Count == 0)
            {
                CartItem cartItem = new CartItem();
                cartItem.SectionID = sectionID;
                cartItem.UserId = userID;

                context.Add(cartItem);
                context.SaveChanges();
            }

            List<CartItem> cartItems = new List<CartItem>();

            cartItems = context.CartItems
                .Where(c => c.UserId == userID)
                .ToList();

            List<SectionViewModel> sectionViewModels = new List<SectionViewModel>();

            foreach (CartItem c in cartItems)
            {
                SectionViewModel sectionViewModel = new SectionViewModel();

                sectionViewModel.Section = context.Sections
                    .Where(s => s.ID == c.SectionID)
                    .ToList()[0];

                sectionViewModel.Course = context.Courses
                    .Where(i => i.ID == sectionViewModel.Section.CourseID)
                    .ToList()[0];

                sectionViewModel.Instructor = context.Instructors
                    .Where(i => i.ID == sectionViewModel.Section.InstructorID)
                    .ToList()[0];

                sectionViewModel.Campus = context.Campuses
                    .Where(i => i.ID == sectionViewModel.Section.CampusID)
                    .ToList()[0];

                sectionViewModel.Meetings = context.Meetings
                    .Where(s => s.SectionID == sectionViewModel.Section.ID)
                    .ToList();

                sectionViewModels.Add(sectionViewModel);
            }


            return View(sectionViewModels);
        }
    }
}