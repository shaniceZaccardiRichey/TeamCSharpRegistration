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
        public IActionResult Browse()
        {
            var courses = context.Courses
                //.Include(c => c.Title)
                .Where(d => d.Department == "IS")
                .OrderBy(c => c.Department).ThenBy(c=> c.Number).ToList();
            return View(courses);     
        }
        
    }
}