using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Data
{
    public class RegistrationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Course> Courses { get; set; }

        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>().HasData(

                new Course { 
                    ID = 1,
                    Department = "ENG",
                    Number = "101",
                    Title = "College Composition I",
                    Description = "College Composition I focuses on the development of writing techniques. Students will develop effective writing styles, writing processes, revision practices, and analytical skills.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 2,
                    Department = "ENG",
                    Number = "102",
                    Title = "College Composition II",
                    Description = "College Composition II builds on knowledge and skills learned in ENG 101 and primarily focuses on argumentative and persuasive writing techniques. Students will develop effective writing processes, writing styles, research abilities, analytical skills, and argumentative tools.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 3,
                    Department = "ENG",
                    Number = "103",
                    Title = "Report Writing",
                    Description = "Report Writing builds on knowledge and skills learned in previous writing courses and primarily focuses on the development of writing techniques required in fields such as business, health science, technology, and engineering. Students will develop effective writing styles, writing processes, and analytical skills for business and technical writing.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 4,
                    Department = "ENG",
                    Number = "201",
                    Title = "Introduction to Fiction",
                    Description = "Introduction to Fiction provides students with an understanding of short and long fiction. Students have the opportunity to study various forms and styles of fiction as well as the major themes and concepts presented within this genre.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 5,
                    Department = "ENG",
                    Number = "205",
                    Title = "American Literature II",
                    Description = "American Literature II provides a survey of American literature from the Civil War to the present. This course includes the topics of literary criticism, textual reception, as well as historical and cultural context. Various authors and genres will be included.",
                    CreditHours = 3,
                    LectureHours = 3
                }

            );
        }

    }
}
