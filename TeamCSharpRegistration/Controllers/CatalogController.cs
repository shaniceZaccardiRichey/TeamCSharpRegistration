﻿using System;
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

        // Shanice - Setup routing for Sections and connected Entity.
        public IActionResult Sections(string course)
        {
            ViewBag.course = course;

            List<Course> courses = new List<Course>();
            courses = context.Courses
                .Where(t => t.Title == course)
                .ToList();

            int courseID = courses[0].ID;

            List<Section> sections = new List<Section>();

            sections = context.Sections
                .Where(c => c.CourseID == courseID)
                .ToList();

            List<SectionViewModel> sectionViewModels = new List<SectionViewModel>();

            foreach (Section section in sections)
            {
                SectionViewModel currentSection = new SectionViewModel();

                currentSection.Section = section;

                currentSection.Course = context.Courses
                    .Where(i => i.ID == courseID)
                    .ToList()[0];

                currentSection.Instructor = context.Instructors
                    .Where(i => i.ID == section.InstructorID)
                    .ToList()[0];

                currentSection.Campus = context.Campuses
                    .Where(i => i.ID == section.CampusID)
                    .ToList()[0];

                currentSection.Meetings = context.Meetings
                    .Where(s => s.SectionID == section.ID)
                    .ToList();

                sectionViewModels.Add(currentSection);
            }

            return View(sectionViewModels);
        }


    }
}