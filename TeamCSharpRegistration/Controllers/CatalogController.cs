using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCSharpRegistration.Data;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Controllers
{
    public class CatalogController : Controller
    {
        // Shanice -Setup Controller to use Entity context
        private RegistrationDbContext context { get; set; }
        public CatalogController(RegistrationDbContext ctx)
        {
            context = ctx;
        }

         // Shanice - Connected entity to department view
        public IActionResult Departments()
        {
            List<Course> courses = new List<Course>();
            List<string> departments = new List<string>();

            courses = context.Courses
                .OrderBy(d => d.Department)
                .ToList();

            foreach (Course course in courses)
            {
                if (!departments.Contains(course.Department))
                {
                    departments.Add(course.Department);
                }
            }

            return View(departments);
            
            /* Old method - 
            var courses = from c in context.Courses select c;
                //.Include(c => c.Title)
            if (!String.IsNullOrEmpty(department))
            {
                courses = courses.Where(d => d.Department == department);
            }
            courses = courses.OrderBy(c => c.Department).ThenBy(c=> c.Number);
            return View(courses.ToList());  
            */
        }

        // Shanice - Connect entity to course view and finished connecting department view to courses view.
        public IActionResult Courses(string department)
        {
            //department = "ENG";

            List<Course> courses = new List<Course>();
            courses = context.Courses
                .Where(d => d.Department == department)
                .OrderBy(n => n.Number)
                .ToList();

            return View(courses);
        }

        public IActionResult Sections(string course)
        {
            ViewBag.course = course;

            return View();
        }


    }
}