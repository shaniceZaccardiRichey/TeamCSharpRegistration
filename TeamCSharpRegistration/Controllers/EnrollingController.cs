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
    // Shanice - Initialize Enrolling Comtroller
    public class EnrollingController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private RegistrationDbContext context { get; set; }

        public EnrollingController(RegistrationDbContext ctx, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            context = ctx;
        }

        // Shanice - Code action for enrolled classes.
        // Shanice & Marshall - Reworked to accomodate routing for remove function.
        public IActionResult EnrolledClasses(int sectionID, string actionType)
        {
            string userID = _userManager.GetUserId(HttpContext.User);

            // Shanice - Implement enroll function
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
            // Marshall - Setup remove function
            else if (actionType == "remove")
            {
                List<EnrolledClass> currentEnrolledClasses = new List<EnrolledClass>();

                // Check for existing entry.
                currentEnrolledClasses = context.EnrolledClasses
                    .Where(c => c.UserId == userID)
                    .Where(s => s.SectionID == sectionID)
                    .ToList();

                if (currentEnrolledClasses.Count != 0)
                {
                    context.Remove(currentEnrolledClasses[0]);
                    context.SaveChanges();

                    ViewBag.AlreadyExistsWarning = "";
                }
                else
                {
                    ViewBag.AlreadyExistsWarning = "Class Not in Cart!";
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

            } else // Shanice - Setup default view of enrolled classes.
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