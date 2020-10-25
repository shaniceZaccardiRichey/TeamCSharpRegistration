using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Data
{
    // Shanice - Setup DbContext for Entity
    public class RegistrationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Course> Courses { get; set; }

        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Shanice - Populated OnBuilder with course data
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
                },

                new Course
                {
                    ID = 6,
                    Department = "IS",
                    Number = "283",
                    Title = "C# Programming III",
                    Description = "Students in this course focus on completing the acquisition of the knowledge and skills for developing applications using Windows Forms, Windows Presentation Foundation (WPF) and the .NET Framework 4 in preparation for Microsoft's Microsoft Certified Technology Specialist (MCTS) .NET Framework 4, Windows Applications certification. Coursework will include developing Windows applications using the C# programming language to access data in Windows forms applications, create Windows services, utilize advanced user interface techniques, implement n-tier applications and implement web applications.",
                    CreditHours = 4,
                    LectureHours = 4
                },

                new Course
                {
                    ID = 7,
                    Department = "IS",
                    Number = "253",
                    Title = "C# Programming II",
                    Description = "C# Programming II focuses on broadening and deepening the student's understanding of Object Oriented Programming (OOP) as implemented in the C# language. Core elements include creating and deploying Windows programs, form application basics, building user interfaces using basic techniques, .NET fundamentals, basic coding within the .NET framework, design and development of classes, overloading and overriding methods and constructors, inheritance, encapsulation, and interfaces. Course objectives align with the Microsoft Certified Technical Specialist (MCTS) .NET Framework, Windows Applications certification.",
                    CreditHours = 4,
                    LectureHours = 4
                },

                new Course
                {
                    ID = 8,
                    Department = "IS",
                    Number = "153",
                    Title = "C# Programming I",
                    Description = "This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment.",
                    CreditHours = 4,
                    LectureHours = 4
                }

            );

            modelBuilder.Entity<Section>().HasData(
                new Section
                {
                    ID = 1,
                    Number = "111",
                    CRN = 283746,
                    CourseID = 1,
                    InstructorID = 1,
                    CampusID = 1,
                    Building = "",
                    Room = "",
                    Type = "Online",
                    StartDate = new DateTime(),
                    EndDate = new DateTime(),
                    Seats = 25,
                    StudentsEnrolled = 5,
                    ScheduleType = "Online",
                    Notes = ""
                }
            );

            modelBuilder.Entity<Campus>().HasData(
               new Campus
               {
                   ID = 1,
                   Code = "ONL",
                   Name = "Online",
                   Address = "online",
                   Phone = ""
               } 
           );

            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    ID = 1,
                    FirstName = "Daniel",
                    LastName = "Yezbick",
                    Email = "dyezbick@stlcc.edu",
                    Phone = "314-123-4567",
                    Department = "IS",
                    CampusID = 1
                }
            );

        }

    }
}
