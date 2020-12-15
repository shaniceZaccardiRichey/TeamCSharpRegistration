using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeamCSharpRegistration.Controllers
{
    public class EnrollingController : Controller
    {
        public IActionResult EnrolledClasses()
        {
            return View();
        }
    }
}