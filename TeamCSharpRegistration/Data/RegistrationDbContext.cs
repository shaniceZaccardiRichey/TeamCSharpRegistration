using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TeamCSharpRegistration.Models;

namespace TeamCSharpRegistration.Data
{
    // Shanice - Setup DbContext for Entity
    //         - Setup DbStes for secondary models.
    //         - Setup cart models.
    public class RegistrationDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<EnrolledClass> EnrolledClasses { get; set; }
        public DbSet<TranscriptItem> TranscriptItems { get; set; }

        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Shanice - Populated OnBuilder with course data, formatted, adjusted.
            //         - Added scraped data (provided by Marshall).

            // Courses
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    ID = 1,
                    Department = "IS",
                    Number = "101",
                    Title = "Keyboarding",
                    Description = @"Keyboarding is a skill-development course designed to introduce touch control of the keyboard using proper techniques. Emphasis is on learning the alphabetic, numeric, and symbol keys. Students learn basic techniques to build speed and accuracy. Satisfactory/Unsatisfactory grading.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 2,
                    Department = "IS",
                    Number = "102",
                    Title = "Keyboarding and Formatting",
                    Description = @"Keyboarding and Formatting is a skill-development course in which students utilize proper techniques to develop touch control of the keyboard and apply basic formatting skills to letters, memos, reports, and tables.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 3,
                    Department = "IS",
                    Number = "109",
                    Title = "Proofreading and Editing",
                    Description = @"Students learn to produce high-quality business communications through proofreading for accuracy in mechanics, format, and content as well as edit documents for correctness, conciseness, and clarity. Prerequisites: IS 101 or IS 102 and Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 4,
                    Department = "IS",
                    Number = "112",
                    Title = "Software and Hardware Architecture",
                    Description = @"Software and Hardware Architecture provides a survey of technical topics related to computer systems with emphasis on the relationships between hardware architecture and systems software. Binary and hexadecimal number systems, data representation, data structures, processor architecture, and operating systems functions and methods will be explored. Recommended Preparation: Basic computer literacy is expected. Prerequisites: MTH 160 or MTH 180 (can be taken concurrently), and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 5,
                    Department = "IS",
                    Number = "116",
                    Title = "Computer Literacy",
                    Description = @"This course explores the terminology and concepts of computers including file management, Internet browsers, and web page development. Students gain proficiency using productivity tools such as word processors, presentation software, electronic spreadsheets and electronic mail to solve problems, communicate, and manage information to make informed decisions. Students will also develop a computer application. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 6,
                    Department = "IS",
                    Number = "120",
                    Title = "Introduction to Excel",
                    Description = @"Introduction to Excel teaches the fundamentals of creating and managing Excel worksheets and workbooks. Topics include creating cells and ranges, creating tables, applying formulas and functions, and creating basic charts and objects to represent data visually. Prerequisites: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 7,
                    Department = "IS",
                    Number = "122",
                    Title = "Windows",
                    Description = @"Windows is a skill-development course covering the Microsoft Windows operating system. Topics include file and folder management and organization, hardware management, software management, network connection, system customization, system optimization, and system security. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 8,
                    Department = "IS",
                    Number = "123",
                    Title = "Introduction to Windows",
                    Description = @"Students learn the basic concepts of the Windows environment and how to create and manage files within the organizational structure of that environment. The desktop, accessories, and navigational tools will also be covered.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 9,
                    Department = "IS",
                    Number = "129",
                    Title = "HTML",
                    Description = @"HTML covers the essentials of creating web pages using Hypertext Markup Language (HTML) and Cascading Style Sheets (CSS). Students will create and edit web pages which include text, hyperlinks, images, and tables. HTML and CSS will be used to control page appearance and layout. Recommended preparation IS 123 or equivalent experience. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 10,
                    Department = "IS",
                    Number = "130",
                    Title = "Hardware Support - CompTIA A+ Core 1 (Hardware)",
                    Description = @"Hardware Support - CompTIA A+ Core 1 (Hardware) covers the theory and hands-on skills necessary to pass the CompTIA A+ hardware (Core 1) exam. Topics covered include hardware fundamentals, networking, and security. Students will learn basic operating system functionality and troubleshooting methodology, the practice of proper safety procedures, and how to effectively interact with customers and co-workers. Recommended Preparation: Basic computer literacy is expected. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 11,
                    Department = "IS",
                    Number = "136",
                    Title = "Internet Fundamentals",
                    Description = @"Internet Fundamentals provides practical information regarding Internet practices and safety. Searching, validating, and securely passing information to and from the Internet are emphasized. Identifying and mitigating common threats such as spyware, viruses, Trojan Horses, and identity theft are covered. Prerequisites: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 12,
                    Department = "IS",
                    Number = "139",
                    Title = "Web Publishing",
                    Description = @"Web Publishing introduces current industry standards for web development and design techniques that include the use of Hypertext Markup Language (HTML), Cascading Style Sheets (CSS), and an introduction to JavaScript. Topics such as web development process, accessibility standards, platform standards, HTML editors and converters, Web 2.0 Technologies, performance issues, tables, forms, dynamic content, and web site management issues will be presented. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 13,
                    Department = "IS",
                    Number = "142",
                    Title = "Web Development I",
                    Description = @"Web Development I is an in-depth study of the development and implementation of engaging websites using current industry production tools. Accessibility, security, and website management issues will be addressed. Topics such as file formats, platform standards, user-centered navigation, dynamic content such as streaming video/audio, and search engine concepts will be presented. Prerequisites: IS 187 or IS 153, IS 139, IS 265 and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 14,
                    Department = "IS",
                    Number = "151",
                    Title = "Computer Applications in Business",
                    Description = @"This course covers software programs frequently used in the business environment. Word processing, spreadsheets, database management, and presentation software will be introduced. Prerequisites: IS 122 or IS 123 or IT 102 or equivalent experience.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 15,
                    Department = "IS",
                    Number = "152",
                    Title = "Computer Applications in Business-Intermediate",
                    Description = @"This class is a continuation of Computer Applications in Business (IS 151). Software packages from these categories will be studied: spreadsheets, database management, word processing, and presentation software. Prerequisites: IS 151 and Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 16,
                    Department = "IS",
                    Number = "153",
                    Title = "C# Programming I",
                    Description = @"This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 17,
                    Department = "PE",
                    Number = "109",
                    Title = "Basic Fitness I",
                    Description = @"This course is an introductory course that focuses on fitness principles and exercise techniques used to develop strength, muscular endurance, flexibility, and cardio-respiratory fitness. A variety of physical activities and exercises will be introduced.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 18,
                    Department = "PE",
                    Number = "120",
                    Title = "Community Red Cross CPR",
                    Description = @"This course provides physiological principles of cardio-pulmonary functions with practical application in administering this lifesaving technique and use of an automated external defibrillator. Certification through the American Red Cross adult, child and infant Cardiopulmonary Resuscitation (CPR) and Automated External Defibrillation (AED) available for those who meet course requirements. Addition fee is required to obtain certification.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 19,
                    Department = "PE",
                    Number = "129",
                    Title = "First Aid",
                    Description = @"This course includes emergency recognition and first aid treatment for sudden illness and injuries with adult cardiopulmonary resuscitation (CPR) and automated external defibrillator (AED). First Aid and CPR/AED certification is available through the one of the following certifying agencies: American Red Cross, National Safety Council, or American Heart Association. This course may be taken to satisfy one credit hour of the physical education requirement. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 20,
                    Department = "PE",
                    Number = "135",
                    Title = "Health and Personal Hygiene",
                    Description = @"This is an introduction to the concept of health being a foundation for positive movement throughout the life cycle. The course will explore the inter-relatedness of the body systems, the nature and communication of disease and the recovery process. Course topics will include healthy eating, fitness, sexuality, drugs, stress, and wellness. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 21,
                    Department = "PE",
                    Number = "161",
                    Title = "Stress Management",
                    Description = @"This course includes an overview of stress and its impact on physical, mental, emotional, and spiritual health and wellness. Coping strategies, relaxation techniques, healthy eating behaviors, and physical activities for stress reduction will be explored. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 22,
                    Department = "PE",
                    Number = "173",
                    Title = "Walking for Fitness",
                    Description = @"This course focuses on the proper technique and attire, and the importance of cardiovascular fitness, weight control, and safety.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 23,
                    Department = "PE",
                    Number = "177",
                    Title = "Weight Training I",
                    Description = @"This course is designed to introduce the beginner to a variety of basic weight training skills. Techniques focus on safe execution of weight lifting using pin-select weight equipment and free weights to develop strength, size, endurance, and flexibility of major muscle groups. Circuit training is introduced.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 24,
                    Department = "PE",
                    Number = "178",
                    Title = "Weight Training II",
                    Description = @"This course focuses on advanced weight lifting techniques utilizing pin-select machines and free weights. Advanced level training programs for increased muscular development are designed. Circuit training is utilized. Prerequisite: PE 177 with a minimum grade of ""C"".",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 25,
                    Department = "PE",
                    Number = "180",
                    Title = "Wellness and Fitness Concepts",
                    Description = @"This course focuses on the impact physical activity, healthy eating behaviors, weight management, stress management, substance abuse, sexually transmitted diseases and other relevant topics have on health and wellness. The development of an individualized wellness program enhances understanding of course concepts. Additional hours required. Prerequisite: Reading Proficiency.",
                    CreditHours = 3,
                    LectureHours = 3
                },

                new Course
                {
                    ID = 26,
                    Department = "PE",
                    Number = "181",
                    Title = "Yoga I (Beginning)",
                    Description = @"This course is an introduction to Hatha Yoga (the Yoga of physical wellbeing), which includes basic poses (asanas), breathing techniques, meditation, and yoga philosophy. Active participation in these activities is designed to increase flexibility and balance, strengthen and tone muscles, and energize the body to reduce stress and enhance physical and mental health.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 27,
                    Department = "PE",
                    Number = "182",
                    Title = "Yoga II (All Levels/Intermediate)",
                    Description = @"This course is a continuation of PE 181, which is an introduction to Hatha Yoga (the Yoga of physical well-being). Active participation and emphasis on awareness and internal focus while practicing advanced yoga asanas (poses), pranayama (controlled breath), and meditation. Performance of these skills and techniques will increase muscle strength and endurance, increase flexibility and balance, improve body posture, reduce stress, and enhance relaxation. Prerequisite: PE 181.",
                    CreditHours = 0,
                    LectureHours = 0
                },

                new Course
                {
                    ID = 28,
                    Department = "PE",
                    Number = "220",
                    Title = "American Heart Association Cardiopulmonary Resuscitation (CPR) for Healthcare Providers",
                    Description = @"This course is designed to prepare students in healthcare professions with basic life support and cardiopulmonary resuscitation (CPR). Students will learn how to recognize cardiac arrest, give chest compressions, deliver ventilations, and provide early use of an automated external defibrillator (AED) individually and with a partner. Adult, child, and infant rescue techniques including choking will be part of this course. American Heart Association Basic Life Support (BLS) for Healthcare Providers certification is available for those who meet the course requirements. Additional fee is required to obtain certification. Prerequisite: Reading Proficiency.",
                    CreditHours = 0,
                    LectureHours = 0
                }
            );

            // Campuses
            modelBuilder.Entity<Campus>().HasData(
               new Campus
               {
                   ID = 1,
                   Code = "NET",
                   Name = "Internet",
                   Address = "",
                   Phone = ""
               },

               new Campus
               {
                   ID = 2,
                   Code = "FV",
                   Name = "Flo Valley",
                   Address = "3400 Pershall Road, Ferguson, MO 63135",
                   Phone = "314-513-4200"
               },

               new Campus
               {
                   ID = 3,
                   Code = "FP",
                   Name = "Forest Park",
                   Address = "5600 Oakland Ave., St. Louis, MO 63110",
                   Phone = "314-644-9100"
               },

               new Campus
               {
                   ID = 4,
                   Code = "MC",
                   Name = "Meramec",
                   Address = "11333 Big Bend Road, St. Louis, MO 63122",
                   Phone = "314-984-7500"
               },

               new Campus
               {
                   ID = 5,
                   Code = "WW",
                   Name = "Wildwood",
                   Address = "2645 Generations Drive, Wildwood, MO 63040",
                   Phone = "636-422-2000"
               }
           );

            // Instructors
            modelBuilder.Entity<Instructor>().HasData(
                new Instructor
                {
                    ID = 1,
                    FirstName = "Stacy",
                    MiddleName = "Gee",
                    LastName = "Hollins",
                    Email = "shollins4@stlcc.edu",
                    Phone = "Not available",
                    Department = "BA",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 2,
                    FirstName = "David",
                    MiddleName = "A",
                    LastName = "Doering",
                    Email = "ddoering7@stlcc.edu",
                    Phone = "314-513-4511",
                    Department = "IS",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 3,
                    FirstName = "John",
                    MiddleName = "T",
                    LastName = "Furlong",
                    Email = "jfurlong11@stlcc.edu",
                    Phone = "314-513-4702",
                    Department = "LS",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 4,
                    FirstName = "Margaret",
                    MiddleName = "M",
                    LastName = "Hvatum",
                    Email = "mhvatum@stlcc.edu",
                    Phone = "314-984-7518",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 5,
                    FirstName = "Gustav",
                    MiddleName = "",
                    LastName = "Adamecz",
                    Email = "gadamecz@stlcc.edu	",
                    Phone = "314-644-9296",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 6,
                    FirstName = "Francelle",
                    MiddleName = "V",
                    LastName = "Darris",
                    Email = "fdarris@stlcc.edu",
                    Phone = "314-644-9082",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 7,
                    FirstName = "Craig",
                    MiddleName = "S",
                    LastName = "Chott",
                    Email = "cchott@stlcc.edu",
                    Phone = "314-644-9298",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 8,
                    FirstName = "Phyllis",
                    MiddleName = "Regina",
                    LastName = "Davis",
                    Email = "pdavis@stlcc.edu",
                    Phone = "314-513-4042",
                    Department = "IS",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 9,
                    FirstName = "Terri",
                    MiddleName = "J",
                    LastName = "Grote",
                    Email = "tgrote@stlcc.edu",
                    Phone = "314-644-9078",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 10,
                    FirstName = "Timothy",
                    MiddleName = "J",
                    LastName = "Roesslein",
                    Email = "troesslein1@stlcc.edu",
                    Phone = "314-644-9273",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 11,
                    FirstName = "Carolyn",
                    MiddleName = "J",
                    LastName = "Calicutt",
                    Email = "ccalicutt@stlcc.edu",
                    Phone = "314-644-9273",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 12,
                    FirstName = "June",
                    MiddleName = "J",
                    LastName = "Mercer",
                    Email = "jmercer@stlcc.edu",
                    Phone = "314-984-7531",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 13,
                    FirstName = "Lisa",
                    MiddleName = "Marie",
                    LastName = "Troxler",
                    Email = "ltroxler@stlcc.edu",
                    Phone = "Not available",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 14,
                    FirstName = "William",
                    MiddleName = "D",
                    LastName = "Hocker",
                    Email = "whocker@stlcc.edu",
                    Phone = "314-644-9084",
                    Department = "IS",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 15,
                    FirstName = "Stevie",
                    MiddleName = "C",
                    LastName = "Calicutt",
                    Email = "sccalicutt@stlcc.edu",
                    Phone = "314-984-7519",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 16,
                    FirstName = "Guangrong",
                    MiddleName = "",
                    LastName = "He",
                    Email = "ghe1@stlcc.edu",
                    Phone = "Not available",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 17,
                    FirstName = "STLCC",
                    MiddleName = "",
                    LastName = "Staff",
                    Email = "",
                    Phone = "",
                    Department = "",
                    CampusID = 1
                },
                new Instructor
                {
                    ID = 18,
                    FirstName = "Tevis",
                    MiddleName = "N",
                    LastName = "Tumulty",
                    Email = "ttumulty@stlcc.edu",
                    Phone = "Not available",
                    Department = "IS",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 19,
                    FirstName = "Anthony",
                    MiddleName = "David",
                    LastName = "Dattoli",
                    Email = "adattoli@stlcc.edu",
                    Phone = "314-984-7785",
                    Department = "PE",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 20,
                    FirstName = "V",
                    MiddleName = "SuzAnne",
                    LastName = "Paez",
                    Email = "vpaez@stlcc.edu",
                    Phone = "314-984-7399",
                    Department = "PE",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 21,
                    FirstName = "Mark",
                    MiddleName = "D",
                    LastName = "Applegate",
                    Email = "mapplegate2@stlcc.edu",
                    Phone = "Not available",
                    Department = "PE",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 22,
                    FirstName = "Michael",
                    MiddleName = "D",
                    LastName = "Dutt",
                    Email = "mdutt@stlcc.edu",
                    Phone = "314-513-4275",
                    Department = "PE",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 23,
                    FirstName = "Michelle",
                    MiddleName = "Rene",
                    LastName = "Ethridge",
                    Email = "methridge1@stlcc.edu",
                    Phone = "314-984-7485",
                    Department = "PE",
                    CampusID = 4
                },
                new Instructor
                {
                    ID = 24,
                    FirstName = "Wayne",
                    MiddleName = "M",
                    LastName = "Bryan",
                    Email = "wbryan@stlcc.edu",
                    Phone = "Not available",
                    Department = "PE",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 25,
                    FirstName = "Joshua",
                    MiddleName = "A",
                    LastName = "Carter",
                    Email = "jcarter308@stlcc.edu",
                    Phone = "Not available",
                    Department = "PE",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 26,
                    FirstName = "Dowon",
                    MiddleName = "",
                    LastName = "Lim",
                    Email = "dlim3@stlcc.edu",
                    Phone = "Not available",
                    Department = "PE",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 27,
                    FirstName = "Mark",
                    MiddleName = "Steven",
                    LastName = "Manteuffel",
                    Email = "mmanteuffel@stlcc.edu",
                    Phone = "314-513-4632",
                    Department = "BIO",
                    CampusID = 2
                },
                new Instructor
                {
                    ID = 28,
                    FirstName = "Bethany",
                    MiddleName = "Jo",
                    LastName = "Bogosian",
                    Email = "bbogosian@stlcc.edu",
                    Phone = "Not available",
                    Department = "PE",
                    CampusID = 3
                },
                new Instructor
                {
                    ID = 29,
                    FirstName = "Liesa",
                    MiddleName = "A",
                    LastName = "Hartin",
                    Email = "lhartin@stlcc.edu",
                    Phone = "636-422-2200",
                    Department = "PE",
                    CampusID = 5
                }

            ); 

            // Sections
            modelBuilder.Entity<Section>().HasData(
                new Section
                {
                    ID = 1,
                    Number = "220",
                    CRN = 30784,
                    CourseID = 1,
                    InstructorID = 1,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 2,
                    Number = "502",
                    CRN = 33506,
                    CourseID = 2,
                    InstructorID = 2,
                    CampusID = 2,
                    Building = "Business Bldg",
                    Room = "122",
                    Type = "In-Class/Online/Virtual Lect.",
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 9,
                    StudentsEnrolled = 9,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term."
                },
                new Section
                {
                    ID = 3,
                    Number = "210",
                    CRN = 30757,
                    CourseID = 2,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 20,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 4,
                    Number = "230",
                    CRN = 31727,
                    CourseID = 3,
                    InstructorID = 3,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 8,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 5,
                    Number = "601",
                    CRN = 30250,
                    CourseID = 4,
                    InstructorID = 4,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 24,
                    StudentsEnrolled = 11,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 6,
                    Number = "450",
                    CRN = 31737,
                    CourseID = 4,
                    InstructorID = 5,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 7,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 7,
                    Number = "210",
                    CRN = 31736,
                    CourseID = 4,
                    InstructorID = 1,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 8,
                    Number = "401",
                    CRN = 31142,
                    CourseID = 5,
                    InstructorID = 6,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 15,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 9,
                    Number = "402",
                    CRN = 31253,
                    CourseID = 5,
                    InstructorID = 6,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 17,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 10,
                    Number = "403",
                    CRN = 31477,
                    CourseID = 5,
                    InstructorID = 7,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 18,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 11,
                    Number = "501",
                    CRN = 33508,
                    CourseID = 5,
                    InstructorID = 8,
                    CampusID = 2,
                    Building = "Business Bldg",
                    Room = "125",
                    Type = "In-Class/Online/Virtual Lect.",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 9,
                    StudentsEnrolled = 6,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term."
                },
                new Section
                {
                    ID = 12,
                    Number = "502",
                    CRN = 33509,
                    CourseID = 5,
                    InstructorID = 8,
                    CampusID = 2,
                    Building = "Business Bldg",
                    Room = "125",
                    Type = "In-Class/Online/Virtual Lect.",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 9,
                    StudentsEnrolled = 6,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term."
                },
                new Section
                {
                    ID = 13,
                    Number = "603",
                    CRN = 31370,
                    CourseID = 5,
                    InstructorID = 9,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 14,
                    Number = "450",
                    CRN = 33082,
                    CourseID = 5,
                    InstructorID = 10,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 6,
                    ScheduleType = "Hybrid",
                    Notes = @"This course is restricted for BJC students. This is a hybrid class which will be held as Live Virtual Lecture. Students are expected to actively participate in the online activities. Students are expected to have access to a computer, internet connection, and basic software such as Microsoft Word. More information about being successful in online classes can be found at https://stlcc.edu/campus-life-community/our-locations/online-education/online-success-beginner.aspx"
                },
                new Section
                {
                    ID = 15,
                    Number = "650",
                    CRN = 31055,
                    CourseID = 5,
                    InstructorID = 9,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 21,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 16,
                    Number = "210",
                    CRN = 31030,
                    CourseID = 5,
                    InstructorID = 11,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 21,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 17,
                    Number = "211",
                    CRN = 31283,
                    CourseID = 5,
                    InstructorID = 12,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 18,
                    Number = "230",
                    CRN = 32173,
                    CourseID = 5,
                    InstructorID = 13,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 19,
                    Number = "240",
                    CRN = 33411,
                    CourseID = 5,
                    InstructorID = 1,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 20,
                    Number = "601",
                    CRN = 31261,
                    CourseID = 5,
                    InstructorID = 7,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 21,
                    Number = "601",
                    CRN = 33549,
                    CourseID = 6,
                    InstructorID = 4,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 10, 28),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 22,
                    Number = "602",
                    CRN = 33550,
                    CourseID = 6,
                    InstructorID = 4,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2020, 12, 23),
                    Seats = 25,
                    StudentsEnrolled = 16,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 23,
                    Number = "230",
                    CRN = 31576,
                    CourseID = 7,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 24,
                    Number = "450",
                    CRN = 32656,
                    CourseID = 8,
                    InstructorID = 10,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 10,
                    ScheduleType = "Online",
                    Notes = @"This is an 8-week open-entry, self-paced course. The last day to register is October 14. Your instructor will e-mail via Blackboard prior to the start of the semester (or, after your registration if the semester has already begun) with important information."
                },
                new Section
                {
                    ID = 25,
                    Number = "220",
                    CRN = 30722,
                    CourseID = 8,
                    InstructorID = 8,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 26,
                    Number = "230",
                    CRN = 30803,
                    CourseID = 8,
                    InstructorID = 10,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 27,
                    Number = "231",
                    CRN = 30810,
                    CourseID = 8,
                    InstructorID = 10,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 28,
                    Number = "230",
                    CRN = 30787,
                    CourseID = 9,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 15,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 29,
                    Number = "450",
                    CRN = 30975,
                    CourseID = 10,
                    InstructorID = 14,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 15,
                    StudentsEnrolled = 6,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 30,
                    Number = "451",
                    CRN = 32634,
                    CourseID = 10,
                    InstructorID = 14,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    Seats = 15,
                    StudentsEnrolled = 9,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 31,
                    Number = "601",
                    CRN = 33094,
                    CourseID = 10,
                    InstructorID = 15,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 12,
                    StudentsEnrolled = 12,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term."
                },
                new Section
                {
                    ID = 32,
                    Number = "501",
                    CRN = 32667,
                    CourseID = 11,
                    InstructorID = 2,
                    CampusID = 2,
                    Building = "Business Bldg",
                    Room = "122",
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    Seats = 9,
                    StudentsEnrolled = 7,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 33,
                    Number = "450",
                    CRN = 33083,
                    CourseID = 11,
                    InstructorID = 10,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    Seats = 18,
                    StudentsEnrolled = 9,
                    ScheduleType = "Hybrid",
                    Notes = @"This course is restricted for BJC students. This is a hybrid class which will be held as Live Virtual Lecture. Students are expected to actively participate in the online activities. Students are expected to have access to a computer, internet connection, and basic software such as Microsoft Word. More information about being successful in online classes can be found at https://stlcc.edu/campus-life-community/our-locations/online-education/online-success-beginner.aspx"
                },
                new Section
                {
                    ID = 34,
                    Number = "450",
                    CRN = 33076,
                    CourseID = 12,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 35,
                    Number = "695",
                    CRN = 31545,
                    CourseID = 12,
                    InstructorID = 16,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 36,
                    Number = "210",
                    CRN = 31159,
                    CourseID = 12,
                    InstructorID = 12,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 37,
                    Number = "230",
                    CRN = 34089,
                    CourseID = 12,
                    InstructorID = 16,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 17,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 38,
                    Number = "240",
                    CRN = 33412,
                    CourseID = 12,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 39,
                    Number = "450",
                    CRN = 33077,
                    CourseID = 13,
                    InstructorID = 2,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 10,
                    ScheduleType = "Hybrid",
                    Notes = null
                },
                new Section
                {
                    ID = 40,
                    Number = "210",
                    CRN = 30976,
                    CourseID = 14,
                    InstructorID = 8,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 22,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 41,
                    Number = "220",
                    CRN = 31575,
                    CourseID = 14,
                    InstructorID = 8,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 13,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 42,
                    Number = "230",
                    CRN = 31614,
                    CourseID = 15,
                    InstructorID = 17,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 4,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 43,
                    Number = "601",
                    CRN = 31262,
                    CourseID = 16,
                    InstructorID = 18,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 44,
                    Number = "650",
                    CRN = 31263,
                    CourseID = 16,
                    InstructorID = 18,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 22,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 45,
                    Number = "601",
                    CRN = 30825,
                    CourseID = 17,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 27,
                    ScheduleType = "Online",
                    Notes = @"Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class."
                },
                new Section
                {
                    ID = 46,
                    Number = "695",
                    CRN = 31672,
                    CourseID = 18,
                    InstructorID = 20,
                    CampusID = 4,
                    Building = "Physical Educ Bldg",
                    Room = "201",
                    Type = "Class",
                    StartDate = new DateTime(2020, 12, 2),
                    EndDate = new DateTime(2020, 12, 2),
                    Seats = 8,
                    StudentsEnrolled = 8,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                This is a hybrid class. Students are expected to participate in online course work and attend class on 10/24 or 10/31 for a 2 hour class session. The date/time will be arranged by the instructor on the first day of class. There is a $19 course fee for certification."
                },
                new Section
                {
                    ID = 47,
                    Number = "490",
                    CRN = 32547,
                    CourseID = 18,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 11,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 48,
                    Number = "570",
                    CRN = 31519,
                    CourseID = 18,
                    InstructorID = 22,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 49,
                    Number = "550",
                    CRN = 33503,
                    CourseID = 19,
                    InstructorID = 22,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 50,
                    Number = "210",
                    CRN = 31742,
                    CourseID = 20,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 51,
                    Number = "220",
                    CRN = 31317,
                    CourseID = 20,
                    InstructorID = 23,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 52,
                    Number = "230",
                    CRN = 31316,
                    CourseID = 20,
                    InstructorID = 23,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 53,
                    Number = "240",
                    CRN = 33431,
                    CourseID = 20,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 54,
                    Number = "601",
                    CRN = 30005,
                    CourseID = 21,
                    InstructorID = 23,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 55,
                    Number = "210",
                    CRN = 30986,
                    CourseID = 21,
                    InstructorID = 24,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 56,
                    Number = "212",
                    CRN = 33432,
                    CourseID = 21,
                    InstructorID = 23,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 57,
                    Number = "213",
                    CRN = 33433,
                    CourseID = 21,
                    InstructorID = 23,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 58,
                    Number = "230",
                    CRN = 31187,
                    CourseID = 21,
                    InstructorID = 24,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 59,
                    Number = "231",
                    CRN = 32157,
                    CourseID = 21,
                    InstructorID = 25,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 18,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 60,
                    Number = "232",
                    CRN = 31286,
                    CourseID = 21,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 17,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 61,
                    Number = "233",
                    CRN = 31752,
                    CourseID = 21,
                    InstructorID = 24,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 8,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 62,
                    Number = "235",
                    CRN = 31440,
                    CourseID = 21,
                    InstructorID = 24,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 63,
                    Number = "240",
                    CRN = 33434,
                    CourseID = 21,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 64,
                    Number = "301",
                    CRN = 30834,
                    CourseID = 21,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 65,
                    Number = "501",
                    CRN = 30770,
                    CourseID = 21,
                    InstructorID = 24,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 66,
                    Number = "650",
                    CRN = 30009,
                    CourseID = 22,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    Seats = 25,
                    StudentsEnrolled = 10,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 67,
                    Number = "201",
                    CRN = 33803,
                    CourseID = 22,
                    InstructorID = 22,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 24,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 68,
                    Number = "230",
                    CRN = 34057,
                    CourseID = 22,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 69,
                    Number = "601",
                    CRN = 32434,
                    CourseID = 23,
                    InstructorID = 26,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 3,
                    ScheduleType = "Online",
                    Notes = @"This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 70,
                    Number = "602",
                    CRN = 30010,
                    CourseID = 23,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 8,
                    ScheduleType = "Online",
                    Notes = @"This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 71,
                    Number = "603",
                    CRN = 30011,
                    CourseID = 23,
                    InstructorID = 26,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 8,
                    ScheduleType = "Online",
                    Notes = @"This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 72,
                    Number = "604",
                    CRN = 33166,
                    CourseID = 23,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 4,
                    ScheduleType = "Online",
                    Notes = @"This course is restricted for the STLCC Baseball players. This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 73,
                    Number = "605",
                    CRN = 33168,
                    CourseID = 23,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 22,
                    ScheduleType = "Online",
                    Notes = @"This course is restricted for STLCC Softball players. This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 74,
                    Number = "606",
                    CRN = 33170,
                    CourseID = 23,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 3,
                    ScheduleType = "Online",
                    Notes = @"This class is specifically for the STLCC Baseball players. Students who enroll in this class will need to sign a liability waiver on or before the first day of class. This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 75,
                    Number = "604",
                    CRN = 33171,
                    CourseID = 24,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 2,
                    ScheduleType = "Online",
                    Notes = @"This course is restricted for the baseball team. This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 76,
                    Number = "605",
                    CRN = 33173,
                    CourseID = 24,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 1,
                    ScheduleType = "Online",
                    Notes = @"Students who enroll in this class will need to sign a liability waiver on or before the first day of class. This class is specifically for STLCC Softball players. This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 77,
                    Number = "606",
                    CRN = 33605,
                    CourseID = 24,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 0,
                    ScheduleType = "Online",
                    Notes = @"This course will focus on body weight exercises for strength development."
                },
                new Section
                {
                    ID = 78,
                    Number = "601",
                    CRN = 33165,
                    CourseID = 25,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 13,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 79,
                    Number = "210",
                    CRN = 31218,
                    CourseID = 25,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 23,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 80,
                    Number = "220",
                    CRN = 30743,
                    CourseID = 25,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 17,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 81,
                    Number = "230",
                    CRN = 31193,
                    CourseID = 25,
                    InstructorID = 19,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 12,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 82,
                    Number = "240",
                    CRN = 33436,
                    CourseID = 25,
                    InstructorID = 21,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 25,
                    StudentsEnrolled = 21,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 83,
                    Number = "501",
                    CRN = 33067,
                    CourseID = 26,
                    InstructorID = 27,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 18,
                    StudentsEnrolled = 11,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 84,
                    Number = "601",
                    CRN = 33475,
                    CourseID = 26,
                    InstructorID = 28,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    Seats = 25,
                    StudentsEnrolled = 25,
                    ScheduleType = "Online",
                    Notes = @"This class is strictly for STLCC athletes."
                },
                new Section
                {
                    ID = 85,
                    Number = "602",
                    CRN = 30013,
                    CourseID = 26,
                    InstructorID = 28,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 14,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 86,
                    Number = "604",
                    CRN = 30749,
                    CourseID = 26,
                    InstructorID = 28,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 4,
                    ScheduleType = "Online",
                    Notes = @"Introduction to Hatha Yoga (the Yoga of physical wellbeing). Designed for students of all physical conditions. Tones and limbers the body, reduces the effects of everyday physical and mental strain. Written observations included in course requirements."
                },
                new Section
                {
                    ID = 87,
                    Number = "340",
                    CRN = 30014,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 5,
                    Building = null,
                    Room = null,
                    Type = "Class",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 20,
                    StudentsEnrolled = 5,
                    ScheduleType = "Activity-Based",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class."
                },
                new Section
                {
                    ID = 88,
                    Number = "350",
                    CRN = 31602,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 5,
                    Building = null,
                    Room = null,
                    Type = "Class",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 20,
                    StudentsEnrolled = 4,
                    ScheduleType = "Activity-Based",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class."
                },
                new Section
                {
                    ID = 89,
                    Number = "401",
                    CRN = 30854,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 16,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 90,
                    Number = "402",
                    CRN = 31234,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 14,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 91,
                    Number = "403",
                    CRN = 31235,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 12,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 92,
                    Number = "486",
                    CRN = 31078,
                    CourseID = 26,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 11,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 93,
                    Number = "502",
                    CRN = 31034,
                    CourseID = 27,
                    InstructorID = 27,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 4,
                    StudentsEnrolled = 1,
                    ScheduleType = "Online",
                    Notes = @"Students are required to bring one pair of dumbbells up to 5 lbs."
                },
                new Section
                {
                    ID = 94,
                    Number = "602",
                    CRN = 31464,
                    CourseID = 27,
                    InstructorID = 28,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 25,
                    StudentsEnrolled = 2,
                    ScheduleType = "Online",
                    Notes = null
                },
                new Section
                {
                    ID = 95,
                    Number = "604",
                    CRN = 30874,
                    CourseID = 27,
                    InstructorID = 28,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Live Virtual Lecture",
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 30,
                    StudentsEnrolled = 0,
                    ScheduleType = "Online",
                    Notes = @"Hatha Yoga (the Yoga of physical wellbeing) is taught. Designed for students of all physical conditions. Tones and limbers the body, reduces the effects of everyday physical and mental strain. Written observations included in course requirements."
                },
                new Section
                {
                    ID = 96,
                    Number = "340",
                    CRN = 30015,
                    CourseID = 27,
                    InstructorID = 29,
                    CampusID = 5,
                    Building = null,
                    Room = null,
                    Type = "Class",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 20,
                    StudentsEnrolled = 3,
                    ScheduleType = "Activity-Based",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class."
                },
                new Section
                {
                    ID = 97,
                    Number = "350",
                    CRN = 31603,
                    CourseID = 27,
                    InstructorID = 29,
                    CampusID = 5,
                    Building = null,
                    Room = null,
                    Type = "Class",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    Seats = 20,
                    StudentsEnrolled = 0,
                    ScheduleType = "Activity-Based",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class."
                },
                new Section
                {
                    ID = 98,
                    Number = "401",
                    CRN = 30725,
                    CourseID = 27,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 4,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 99,
                    Number = "490",
                    CRN = 31236,
                    CourseID = 27,
                    InstructorID = 29,
                    CampusID = 1,
                    Building = null,
                    Room = null,
                    Type = "Web-Based / Internet",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    Seats = 16,
                    StudentsEnrolled = 1,
                    ScheduleType = "Online",
                    Notes = @"This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times."
                },
                new Section
                {
                    ID = 100,
                    Number = "490",
                    CRN = 31623,
                    CourseID = 28,
                    InstructorID = 21,
                    CampusID = 3,
                    Building = "Physical Ed Bldg TB",
                    Room = "A",
                    Type = "In-Class/Online/Virtual Lect.",
                    StartDate = new DateTime(2020, 10, 2),
                    EndDate = new DateTime(2020, 10, 14),
                    Seats = 9,
                    StudentsEnrolled = 8,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                There is an additional fee of $10.00 for students wishing to purchase the AHA certification card."
                },
                new Section
                {
                    ID = 101,
                    Number = "501",
                    CRN = 32222,
                    CourseID = 28,
                    InstructorID = 24,
                    CampusID = 2,
                    Building = "Physical Ed Bldg",
                    Room = "204",
                    Type = "In-Class/Online/Virtual Lect.",
                    StartDate = new DateTime(2020, 10, 13),
                    EndDate = new DateTime(2020, 10, 14),
                    Seats = 8,
                    StudentsEnrolled = 7,
                    ScheduleType = "Hybrid",
                    Notes = @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                There is an additional fee of $10.00 for students wishing to purchase their AHA certification card."
                }


            );

            // Meetings
            modelBuilder.Entity<Meeting>().HasData(
                new Meeting
                {
                    ID = 1,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 1,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 2,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "122",
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 10, 0),
                    Day = "M",
                    SectionID = 2,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 3,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "122",
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 10, 0),
                    Day = "W",
                    SectionID = 2,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 4,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 3,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 5,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 4,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 6,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 45, 0),
                    Day = "T",
                    SectionID = 5,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 7,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 45, 0),
                    Day = "R",
                    SectionID = 5,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 8,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 6,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 9,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 18, 45, 0),
                    Day = "W",
                    SectionID = 6,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 10,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 7,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 11,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 45, 0),
                    Day = "T",
                    SectionID = 8,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 12,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 45, 0),
                    Day = "R",
                    SectionID = 8,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 13,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "T",
                    SectionID = 9,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 14,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "R",
                    SectionID = 9,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 15,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 50, 0),
                    Day = "M",
                    SectionID = 10,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 16,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 50, 0),
                    Day = "W",
                    SectionID = 10,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 17,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 50, 0),
                    Day = "F",
                    SectionID = 10,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 18,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "125",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 45, 0),
                    Day = "T",
                    SectionID = 11,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 19,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "125",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 45, 0),
                    Day = "R",
                    SectionID = 11,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 20,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "125",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "T",
                    SectionID = 12,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 21,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Business Bldg",
                    Room = "125",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "R",
                    SectionID = 12,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 22,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 50, 0),
                    Day = "M",
                    SectionID = 13,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 23,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 50, 0),
                    Day = "W",
                    SectionID = 13,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 24,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 50, 0),
                    Day = "F",
                    SectionID = 13,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 25,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 14,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 26,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 19, 15, 0),
                    Day = "R",
                    SectionID = 14,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 27,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 21, 40, 0),
                    Day = "R",
                    SectionID = 15,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 28,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 16,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 29,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 17,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 30,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 18,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 31,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 19,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 32,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 20,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 33,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 10, 28),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "T",
                    SectionID = 21,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 34,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 10, 28),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "R",
                    SectionID = 21,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 35,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2020, 12, 23),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "T",
                    SectionID = 22,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 36,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2020, 12, 23),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 15, 0),
                    Day = "R",
                    SectionID = 22,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 37,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 23,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 38,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 18, 30, 0),
                    Day = "W",
                    SectionID = 24,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 39,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 25,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 40,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 26,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 41,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 27,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 42,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 28,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 43,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 29,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 44,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 10, 0),
                    Day = "R",
                    SectionID = 29,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 45,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 30,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 46,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 10, 0),
                    Day = "T",
                    SectionID = 30,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 47,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 31,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 48,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 21, 50, 0),
                    Day = "W",
                    SectionID = 31,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 49,
                    Type = "Live Virtual Lecture",
                    Building = "Business Bldg",
                    Room = "122",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 50, 0),
                    Day = "M",
                    SectionID = 32,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 50,
                    Type = "Live Virtual Lecture",
                    Building = "Business Bldg",
                    Room = "122",
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 50, 0),
                    Day = "W",
                    SectionID = 32,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 51,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 33,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 52,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 19, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 50, 0),
                    Day = "R",
                    SectionID = 33,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 53,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 34,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 54,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 18, 45, 0),
                    Day = "T",
                    SectionID = 34,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 55,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 35,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 56,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 20, 0),
                    Day = "T",
                    SectionID = 35,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 57,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 36,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 58,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 38,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 59,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 39,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 60,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 10, 22),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 15, 0),
                    Day = "T",
                    SectionID = 39,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 61,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 40,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 62,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 41,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 63,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 42,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 64,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 10, 0),
                    Day = "M",
                    SectionID = 43,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 65,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 10, 0),
                    Day = "W",
                    SectionID = 43,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 66,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 10, 10, 0),
                    Day = "F",
                    SectionID = 43,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 67,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 18, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 21, 40, 0),
                    Day = "W",
                    SectionID = 44,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 68,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 35, 0),
                    Day = "T",
                    SectionID = 45,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 69,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 35, 0),
                    Day = "R",
                    SectionID = 45,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 70,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 46,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 71,
                    Type = "Class",
                    Building = "Physical Educ Bldg",
                    Room = "201",
                    StartDate = new DateTime(2020, 11, 25),
                    EndDate = new DateTime(2020, 11, 25),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    Day = "S",
                    SectionID = 46,
                    CampusID = 4
                },
                new Meeting
                {
                    ID = 72,
                    Type = "Class",
                    Building = "Physical Educ Bldg",
                    Room = "201",
                    StartDate = new DateTime(2020, 12, 2),
                    EndDate = new DateTime(2020, 12, 2),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    Day = "S",
                    SectionID = 46,
                    CampusID = 4
                },
                new Meeting
                {
                    ID = 73,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 47,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 74,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 48,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 75,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 49,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 76,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 50,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 77,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 51,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 78,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 52,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 79,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 53,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 80,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 35, 0),
                    Day = "M",
                    SectionID = 54,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 81,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 35, 0),
                    Day = "W",
                    SectionID = 54,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 82,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 55,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 83,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 56,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 84,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 57,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 85,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 58,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 86,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 59,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 87,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 60,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 88,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 61,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 89,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 62,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 90,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 63,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 91,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 64,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 92,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 65,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 93,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 18, 45, 0),
                    Day = "T",
                    SectionID = 66,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 94,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 18, 45, 0),
                    Day = "R",
                    SectionID = 66,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 95,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 67,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 96,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 5, 0),
                    Day = "M",
                    SectionID = 69,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 97,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 5, 0),
                    Day = "W",
                    SectionID = 69,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 98,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 12, 5, 0),
                    Day = "F",
                    SectionID = 69,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 99,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 50, 0),
                    Day = "T",
                    SectionID = 70,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 100,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 11, 50, 0),
                    Day = "R",
                    SectionID = 70,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 101,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 20, 0),
                    Day = "T",
                    SectionID = 71,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 102,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 20, 0),
                    Day = "R",
                    SectionID = 71,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 103,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "M",
                    SectionID = 72,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 104,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "W",
                    SectionID = 72,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 105,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "F",
                    SectionID = 72,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 106,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "M",
                    SectionID = 73,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 107,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "W",
                    SectionID = 73,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 108,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "F",
                    SectionID = 73,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 109,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "M",
                    SectionID = 74,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 110,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "W",
                    SectionID = 74,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 111,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "F",
                    SectionID = 74,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 112,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "M",
                    SectionID = 75,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 113,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "W",
                    SectionID = 75,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 114,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 7, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 55, 0),
                    Day = "F",
                    SectionID = 75,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 115,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "M",
                    SectionID = 76,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 116,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "W",
                    SectionID = 76,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 117,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 14, 5, 0),
                    Day = "F",
                    SectionID = 76,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 118,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "M",
                    SectionID = 77,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 119,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "W",
                    SectionID = 77,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 120,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 6, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 7, 5, 0),
                    Day = "F",
                    SectionID = 77,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 121,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 9, 35, 0),
                    Day = "M",
                    SectionID = 78,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 122,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 9, 35, 0),
                    Day = "W",
                    SectionID = 78,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 123,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 79,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 124,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 80,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 125,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 81,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 126,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 82,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 127,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 45, 0),
                    Day = "R",
                    SectionID = 83,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 128,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 12, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 35, 0),
                    Day = "W",
                    SectionID = 84,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 129,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2020, 11, 19),
                    StartTime = new DateTime(1970, 1, 1, 12, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 35, 0),
                    Day = "F",
                    SectionID = 84,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 130,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 8, 50, 0),
                    Day = "T",
                    SectionID = 85,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 131,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 8, 50, 0),
                    Day = "R",
                    SectionID = 85,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 132,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 45, 0),
                    Day = "T",
                    SectionID = 86,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 133,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 45, 0),
                    Day = "R",
                    SectionID = 86,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 134,
                    Type = "Class",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    Day = "T",
                    SectionID = 87,
                    CampusID = 5
                },
                new Meeting
                {
                    ID = 135,
                    Type = "Class",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 15, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 45, 0),
                    Day = "T",
                    SectionID = 88,
                    CampusID = 5
                },
                new Meeting
                {
                    ID = 136,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 89,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 137,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 90,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 138,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 91,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 139,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 92,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 140,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 45, 0),
                    Day = "R",
                    SectionID = 93,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 141,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 8, 50, 0),
                    Day = "T",
                    SectionID = 94,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 142,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 8, 50, 0),
                    Day = "R",
                    SectionID = 94,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 143,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 45, 0),
                    Day = "T",
                    SectionID = 95,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 144,
                    Type = "Live Virtual Lecture",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 11, 20),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 45, 0),
                    Day = "R",
                    SectionID = 95,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 145,
                    Type = "Class",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 17, 30, 0),
                    EndTime = new DateTime(1970, 1, 1, 19, 0, 0),
                    Day = "T",
                    SectionID = 96,
                    CampusID = 5
                },
                new Meeting
                {
                    ID = 146,
                    Type = "Class",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 9, 25),
                    EndDate = new DateTime(2021, 1, 21),
                    StartTime = new DateTime(1970, 1, 1, 19, 15, 0),
                    EndTime = new DateTime(1970, 1, 1, 20, 45, 0),
                    Day = "T",
                    SectionID = 97,
                    CampusID = 5
                },
                new Meeting
                {
                    ID = 147,
                    Type = "Web-Based / Internet",
                    Building = null,
                    Room = null,
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 98,
                    CampusID = 1
                },
                new Meeting
                {
                    ID = 148,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg TB",
                    Room = "A",
                    StartDate = new DateTime(2020, 8, 21),
                    EndDate = new DateTime(2020, 12, 13),
                    StartTime = new DateTime(1970, 1, 1, 0, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 0, 1, 0),
                    Day = null,
                    SectionID = 99,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 149,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg TB",
                    Room = "A",
                    StartDate = new DateTime(2020, 10, 2),
                    EndDate = new DateTime(2020, 10, 14),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 55, 0),
                    Day = "W",
                    SectionID = 100,
                    CampusID = 3
                },
                new Meeting
                {
                    ID = 150,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg TB",
                    Room = "A",
                    StartDate = new DateTime(2020, 10, 2),
                    EndDate = new DateTime(2020, 10, 14),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 55, 0),
                    Day = "T",
                    SectionID = 100,
                    CampusID = 3
                },
                new Meeting
                {
                    ID = 151,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg TB",
                    Room = "A",
                    StartDate = new DateTime(2020, 10, 2),
                    EndDate = new DateTime(2020, 10, 14),
                    StartTime = new DateTime(1970, 1, 1, 14, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 15, 55, 0),
                    Day = "R",
                    SectionID = 100,
                    CampusID = 3
                },
                new Meeting
                {
                    ID = 152,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg",
                    Room = "204",
                    StartDate = new DateTime(2020, 10, 13),
                    EndDate = new DateTime(2020, 10, 14),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    Day = "S",
                    SectionID = 101,
                    CampusID = 2
                },
                new Meeting
                {
                    ID = 153,
                    Type = "In-Class/Online/Virtual Lect.",
                    Building = "Physical Ed Bldg",
                    Room = "204",
                    StartDate = new DateTime(2020, 10, 13),
                    EndDate = new DateTime(2020, 10, 14),
                    StartTime = new DateTime(1970, 1, 1, 9, 0, 0),
                    EndTime = new DateTime(1970, 1, 1, 13, 0, 0),
                    Day = "U",
                    SectionID = 101,
                    CampusID = 2
                }
            );

        }

    }
}
