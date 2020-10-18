using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TeamCSharpRegistration.Data;

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

         // Shanice - Connected entity to browse view
        public IActionResult Browse(string department)
        {
            var courses = from c in context.Courses select c;
                //.Include(c => c.Title)
            if (!String.IsNullOrEmpty(department))
            {
                courses = courses.Where(d => d.Department == department);
            }
            courses = courses.OrderBy(c => c.Department).ThenBy(c=> c.Number);
            return View(courses.ToList());     
        }
        
    }
}