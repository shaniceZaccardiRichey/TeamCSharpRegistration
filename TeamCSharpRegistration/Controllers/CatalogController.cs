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
        private RegistrationDbContext context { get; set; }
        public CatalogController(RegistrationDbContext ctx)
        {
            context = ctx;
        }


        public IActionResult Browse()
        {
            var courses = context.Courses
                //.Include(c => c.Title)
                .OrderBy(c => c.Department).ToList();
            return View(courses);     
        }
        
    }
}