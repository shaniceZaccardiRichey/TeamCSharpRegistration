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
                List<EnrolledClass> toEnroll = new List<EnrolledClass>();

                cartItems = context.CartItems
                    .Where(c => c.UserId == userID)
                    .ToList();

                foreach (CartItem c in cartItems)
                {
                    EnrolledClass currentClass = new EnrolledClass();
                    currentClass.SectionID = c.SectionID;
                    currentClass.UserId = userID;

                    toEnroll.Add(currentClass);

                    context.Remove(c);
                    context.SaveChanges();
                }

                foreach (EnrolledClass e in toEnroll)
                {
                    context.Add(e);
                    context.SaveChanges();
                }

                List<EnrolledClass> enrolledClasses = new List<EnrolledClass>();

                enrolledClasses = context.EnrolledClasses
                    .Where(c => c.UserId == userID)
                    .ToList();

                List<SectionViewModel> sectionViewModels = new List<SectionViewModel>();

                foreach (EnrolledClass e in enrolledClasses)
                {
                    SectionViewModel sectionViewModel = new SectionViewModel();

                    sectionViewModel.Section = context.Sections
                        .Where(s => s.ID == e.SectionID)
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
            else if (actionType == "remove")
            {
                return View();
            }else
            {
                List<EnrolledClass> enrolledClasses = new List<EnrolledClass>();

                enrolledClasses = context.EnrolledClasses
                    .Where(c => c.UserId == userID)
                    .ToList();

                List<SectionViewModel> sectionViewModels = new List<SectionViewModel>();

                foreach (EnrolledClass e in enrolledClasses)
                {
                    SectionViewModel sectionViewModel = new SectionViewModel();

                    sectionViewModel.Section = context.Sections
                        .Where(s => s.ID == e.SectionID)
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
}