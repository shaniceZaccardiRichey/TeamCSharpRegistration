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
        public DbSet<Section> Sections { get; set; }
        

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
                },

                new Course
                {
                    ID = 9,
                    Department = "IS",
                    Number = "101",
                    Title = "Keyboarding",
                    Description = @"Keyboarding is a skill-development course designed to introduce touch control of the keyboard using proper techniques. Emphasis is on learning the alphabetic, numeric, and symbol keys. Students learn basic techniques to build speed and accuracy. Satisfactory/Unsatisfactory grading.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 10,
                    Department = "IS",
                    Number = "102",
                    Title = "Keyboarding and Formatting",
                    Description = @"Keyboarding and Formatting is a skill-development course in which students utilize proper techniques to develop touch control of the keyboard and apply basic formatting skills to letters, memos, reports, and tables.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 11,
                    Department = "IS",
                    Number = "109",
                    Title = "Proofreading and Editing",
                    Description = @"Students learn to produce high-quality business communications through proofreading for accuracy in mechanics, format, and content as well as edit documents for correctness, conciseness, and clarity. Prerequisites: IS 101 or IS 102 and Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 12,
                    Department = "IS",
                    Number = "112",
                    Title = "Software and Hardware Architecture",
                    Description = @"Software and Hardware Architecture provides a survey of technical topics related to computer systems with emphasis on the relationships between hardware architecture and systems software. Binary and hexadecimal number systems, data representation, data structures, processor architecture, and operating systems functions and methods will be explored. Recommended Preparation: Basic computer literacy is expected. Prerequisites: MTH 160 or MTH 180 (can be taken concurrently), and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 13,
                    Department = "IS",
                    Number = "116",
                    Title = "Computer Literacy",
                    Description = @"This course explores the terminology and concepts of computers including file management, Internet browsers, and web page development. Students gain proficiency using productivity tools such as word processors, presentation software, electronic spreadsheets and electronic mail to solve problems, communicate, and manage information to make informed decisions. Students will also develop a computer application. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 14,
                    Department = "IS",
                    Number = "120",
                    Title = "Introduction to Excel",
                    Description = @"Introduction to Excel teaches the fundamentals of creating and managing Excel worksheets and workbooks. Topics include creating cells and ranges, creating tables, applying formulas and functions, and creating basic charts and objects to represent data visually. Prerequisites: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 15,
                    Department = "IS",
                    Number = "122",
                    Title = "Windows",
                    Description = @"Windows is a skill-development course covering the Microsoft Windows operating system. Topics include file and folder management and organization, hardware management, software management, network connection, system customization, system optimization, and system security. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 16,
                    Department = "IS",
                    Number = "123",
                    Title = "Introduction to Windows",
                    Description = @"Students learn the basic concepts of the Windows environment and how to create and manage files within the organizational structure of that environment. The desktop, accessories, and navigational tools will also be covered.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 17,
                    Department = "IS",
                    Number = "129",
                    Title = "HTML",
                    Description = @"HTML covers the essentials of creating web pages using Hypertext Markup Language (HTML) and Cascading Style Sheets (CSS). Students will create and edit web pages which include text, hyperlinks, images, and tables. HTML and CSS will be used to control page appearance and layout. Recommended preparation IS 123 or equivalent experience. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 18,
                    Department = "IS",
                    Number = "130",
                    Title = "Hardware Support - CompTIA A+ Core 1 (Hardware)",
                    Description = @"Hardware Support - CompTIA A+ Core 1 (Hardware) covers the theory and hands-on skills necessary to pass the CompTIA A+ hardware (Core 1) exam. Topics covered include hardware fundamentals, networking, and security. Students will learn basic operating system functionality and troubleshooting methodology, the practice of proper safety procedures, and how to effectively interact with customers and co-workers. Recommended Preparation: Basic computer literacy is expected. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 19,
                    Department = "IS",
                    Number = "136",
                    Title = "Internet Fundamentals",
                    Description = @"Internet Fundamentals provides practical information regarding Internet practices and safety. Searching, validating, and securely passing information to and from the Internet are emphasized. Identifying and mitigating common threats such as spyware, viruses, Trojan Horses, and identity theft are covered. Prerequisites: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 20,
                    Department = "IS",
                    Number = "139",
                    Title = "Web Publishing",
                    Description = @"Web Publishing introduces current industry standards for web development and design techniques that include the use of Hypertext Markup Language (HTML), Cascading Style Sheets (CSS), and an introduction to JavaScript. Topics such as web development process, accessibility standards, platform standards, HTML editors and converters, Web 2.0 Technologies, performance issues, tables, forms, dynamic content, and web site management issues will be presented. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 21,
                    Department = "IS",
                    Number = "142",
                    Title = "Web Development I",
                    Description = @"Web Development I is an in-depth study of the development and implementation of engaging websites using current industry production tools. Accessibility, security, and website management issues will be addressed. Topics such as file formats, platform standards, user-centered navigation, dynamic content such as streaming video/audio, and search engine concepts will be presented. Prerequisites: IS 187 or IS 153, IS 139, IS 265 and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 22,
                    Department = "IS",
                    Number = "151",
                    Title = "Computer Applications in Business",
                    Description = @"This course covers software programs frequently used in the business environment. Word processing, spreadsheets, database management, and presentation software will be introduced. Prerequisites: IS 122 or IS 123 or IT 102 or equivalent experience.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 23,
                    Department = "IS",
                    Number = "152",
                    Title = "Computer Applications in Business-Intermediate",
                    Description = @"This class is a continuation of Computer Applications in Business (IS 151). Software packages from these categories will be studied: spreadsheets, database management, word processing, and presentation software. Prerequisites: IS 151 and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 24,
                    Department = "IS",
                    Number = "153",
                    Title = "C# Programming I",
                    Description = @"This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 25,
                    Department = "PE",
                    Number = "109",
                    Title = "Basic Fitness I",
                    Description = @"This course is an introductory course that focuses on fitness principles and exercise techniques used to develop strength, muscular endurance, flexibility, and cardio-respiratory fitness. A variety of physical activities and exercises will be introduced.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 26,
                    Department = "PE",
                    Number = "120",
                    Title = "Community Red Cross CPR",
                    Description = @"This course provides physiological principles of cardio-pulmonary functions with practical application in administering this lifesaving technique and use of an automated external defibrillator. Certification through the American Red Cross adult, child and infant Cardiopulmonary Resuscitation (CPR) and Automated External Defibrillation (AED) available for those who meet course requirements. Addition fee is required to obtain certification.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 27,
                    Department = "PE",
                    Number = "129",
                    Title = "First Aid",
                    Description = @"This course includes emergency recognition and first aid treatment for sudden illness and injuries with adult cardiopulmonary resuscitation (CPR) and automated external defibrillator (AED). First Aid and CPR/AED certification is available through the one of the following certifying agencies: American Red Cross, National Safety Council, or American Heart Association. This course may be taken to satisfy one credit hour of the physical education requirement. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 28,
                    Department = "PE",
                    Number = "135",
                    Title = "Health and Personal Hygiene",
                    Description = @"This is an introduction to the concept of health being a foundation for positive movement throughout the life cycle. The course will explore the inter-relatedness of the body systems, the nature and communication of disease and the recovery process. Course topics will include healthy eating, fitness, sexuality, drugs, stress, and wellness. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 29,
                    Department = "PE",
                    Number = "161",
                    Title = "Stress Management",
                    Description = @"This course includes an overview of stress and its impact on physical, mental, emotional, and spiritual health and wellness. Coping strategies, relaxation techniques, healthy eating behaviors, and physical activities for stress reduction will be explored. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 30,
                    Department = "PE",
                    Number = "173",
                    Title = "Walking for Fitness",
                    Description = @"This course focuses on the proper technique and attire, and the importance of cardiovascular fitness, weight control, and safety.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 31,
                    Department = "PE",
                    Number = "177",
                    Title = "Weight Training I",
                    Description = @"This course is designed to introduce the beginner to a variety of basic weight training skills. Techniques focus on safe execution of weight lifting using pin-select weight equipment and free weights to develop strength, size, endurance, and flexibility of major muscle groups. Circuit training is introduced.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 32,
                    Department = "PE",
                    Number = "178",
                    Title = "Weight Training II",
                    Description = @"This course focuses on advanced weight lifting techniques utilizing pin-select machines and free weights. Advanced level training programs for increased muscular development are designed. Circuit training is utilized. Prerequisite: PE 177 with a minimum grade of 'C'.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 33,
                    Department = "PE",
                    Number = "180",
                    Title = "Wellness and Fitness Concepts",
                    Description = @"This course focuses on the impact physical activity, healthy eating behaviors, weight management, stress management, substance abuse, sexually transmitted diseases and other relevant topics have on health and wellness. The development of an individualized wellness program enhances understanding of course concepts. Additional hours required. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 34,
                    Department = "PE",
                    Number = "181",
                    Title = "Yoga I (Beginning)",
                    Description = @"This course is an introduction to Hatha Yoga (the Yoga of physical wellbeing), which includes basic poses (asanas), breathing techniques, meditation, and yoga philosophy. Active participation in these activities is designed to increase flexibility and balance, strengthen and tone muscles, and energize the body to reduce stress and enhance physical and mental health.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 35,
                    Department = "PE",
                    Number = "182",
                    Title = "Yoga II (All Levels/Intermediate)",
                    Description = @"This course is a continuation of PE 181, which is an introduction to Hatha Yoga (the Yoga of physical well-being). Active participation and emphasis on awareness and internal focus while practicing advanced yoga asanas (poses), pranayama (controlled breath), and meditation. Performance of these skills and techniques will increase muscle strength and endurance, increase flexibility and balance, improve body posture, reduce stress, and enhance relaxation. Prerequisite: PE 181.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 36,
                    Department = "PE",
                    Number = "220",
                    Title = "American Heart Association Cardiopulmonary Resuscitation (CPR) for Healthcare Providers",
                    Description = @"This course is designed to prepare students in healthcare professions with basic life support and cardiopulmonary resuscitation (CPR). Students will learn how to recognize cardiac arrest, give chest compressions, deliver ventilations, and provide early use of an automated external defibrillator (AED) individually and with a partner. Adult, child, and infant rescue techniques including choking will be part of this course. American Heart Association Basic Life Support (BLS) for Healthcare Providers certification is available for those who meet the course requirements. Additional fee is required to obtain certification. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
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
