using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campuses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Department = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    CreditHours = table.Column<int>(nullable: false),
                    LectureHours = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    CampusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructors_Campuses_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranscriptItems",
                columns: table => new
                {
                    TranscriptItemID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    CourseID = table.Column<int>(nullable: false),
                    Grade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranscriptItems", x => x.TranscriptItemID);
                    table.ForeignKey(
                        name: "FK_TranscriptItems_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranscriptItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Number = table.Column<string>(nullable: true),
                    CRN = table.Column<int>(nullable: false),
                    CourseID = table.Column<int>(nullable: false),
                    InstructorID = table.Column<int>(nullable: false),
                    CampusID = table.Column<int>(nullable: false),
                    Building = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Seats = table.Column<int>(nullable: false),
                    StudentsEnrolled = table.Column<int>(nullable: false),
                    ScheduleType = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sections_Campuses_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    SectionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemID);
                    table.ForeignKey(
                        name: "FK_CartItems_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnrolledClasses",
                columns: table => new
                {
                    EnrolledClassID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    SectionID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnrolledClasses", x => x.EnrolledClassID);
                    table.ForeignKey(
                        name: "FK_EnrolledClasses_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EnrolledClasses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Meetings",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Building = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Day = table.Column<string>(nullable: true),
                    SectionID = table.Column<int>(nullable: false),
                    CampusID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Meetings_Campuses_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Meetings_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campuses",
                columns: new[] { "ID", "Address", "Code", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "", "NET", "Internet", "" },
                    { 2, "3400 Pershall Road, Ferguson, MO 63135", "FV", "Flo Valley", "314-513-4200" },
                    { 3, "5600 Oakland Ave., St. Louis, MO 63110", "FP", "Forest Park", "314-644-9100" },
                    { 4, "11333 Big Bend Road, St. Louis, MO 63122", "MC", "Meramec", "314-984-7500" },
                    { 5, "2645 Generations Drive, Wildwood, MO 63040", "WW", "Wildwood", "636-422-2000" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[,]
                {
                    { 16, 0, "IS", "This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment. Prerequisite: Reading Proficiency.", 0, "153", "C# Programming I" },
                    { 17, 0, "PE", "This course is an introductory course that focuses on fitness principles and exercise techniques used to develop strength, muscular endurance, flexibility, and cardio-respiratory fitness. A variety of physical activities and exercises will be introduced.", 0, "109", "Basic Fitness I" },
                    { 18, 0, "PE", "This course provides physiological principles of cardio-pulmonary functions with practical application in administering this lifesaving technique and use of an automated external defibrillator. Certification through the American Red Cross adult, child and infant Cardiopulmonary Resuscitation (CPR) and Automated External Defibrillation (AED) available for those who meet course requirements. Addition fee is required to obtain certification.", 0, "120", "Community Red Cross CPR" },
                    { 19, 0, "PE", "This course includes emergency recognition and first aid treatment for sudden illness and injuries with adult cardiopulmonary resuscitation (CPR) and automated external defibrillator (AED). First Aid and CPR/AED certification is available through the one of the following certifying agencies: American Red Cross, National Safety Council, or American Heart Association. This course may be taken to satisfy one credit hour of the physical education requirement. Prerequisite: Reading Proficiency.", 0, "129", "First Aid" },
                    { 20, 3, "PE", "This is an introduction to the concept of health being a foundation for positive movement throughout the life cycle. The course will explore the inter-relatedness of the body systems, the nature and communication of disease and the recovery process. Course topics will include healthy eating, fitness, sexuality, drugs, stress, and wellness. Prerequisite: Reading Proficiency.", 3, "135", "Health and Personal Hygiene" },
                    { 23, 0, "PE", "This course is designed to introduce the beginner to a variety of basic weight training skills. Techniques focus on safe execution of weight lifting using pin-select weight equipment and free weights to develop strength, size, endurance, and flexibility of major muscle groups. Circuit training is introduced.", 0, "177", "Weight Training I" },
                    { 22, 0, "PE", "This course focuses on the proper technique and attire, and the importance of cardiovascular fitness, weight control, and safety.", 0, "173", "Walking for Fitness" },
                    { 15, 3, "IS", "This class is a continuation of Computer Applications in Business (IS 151). Software packages from these categories will be studied: spreadsheets, database management, word processing, and presentation software. Prerequisites: IS 151 and Reading Proficiency.", 3, "152", "Computer Applications in Business-Intermediate" },
                    { 24, 0, "PE", "This course focuses on advanced weight lifting techniques utilizing pin-select machines and free weights. Advanced level training programs for increased muscular development are designed. Circuit training is utilized. Prerequisite: PE 177 with a minimum grade of \"C\".", 0, "178", "Weight Training II" },
                    { 25, 3, "PE", "This course focuses on the impact physical activity, healthy eating behaviors, weight management, stress management, substance abuse, sexually transmitted diseases and other relevant topics have on health and wellness. The development of an individualized wellness program enhances understanding of course concepts. Additional hours required. Prerequisite: Reading Proficiency.", 3, "180", "Wellness and Fitness Concepts" },
                    { 26, 0, "PE", "This course is an introduction to Hatha Yoga (the Yoga of physical wellbeing), which includes basic poses (asanas), breathing techniques, meditation, and yoga philosophy. Active participation in these activities is designed to increase flexibility and balance, strengthen and tone muscles, and energize the body to reduce stress and enhance physical and mental health.", 0, "181", "Yoga I (Beginning)" },
                    { 21, 3, "PE", "This course includes an overview of stress and its impact on physical, mental, emotional, and spiritual health and wellness. Coping strategies, relaxation techniques, healthy eating behaviors, and physical activities for stress reduction will be explored. Prerequisite: Reading Proficiency.", 3, "161", "Stress Management" },
                    { 14, 0, "IS", "This course covers software programs frequently used in the business environment. Word processing, spreadsheets, database management, and presentation software will be introduced. Prerequisites: IS 122 or IS 123 or IT 102 or equivalent experience.", 0, "151", "Computer Applications in Business" },
                    { 12, 3, "IS", "Web Publishing introduces current industry standards for web development and design techniques that include the use of Hypertext Markup Language (HTML), Cascading Style Sheets (CSS), and an introduction to JavaScript. Topics such as web development process, accessibility standards, platform standards, HTML editors and converters, Web 2.0 Technologies, performance issues, tables, forms, dynamic content, and web site management issues will be presented. Prerequisite: Reading Proficiency.", 3, "139", "Web Publishing" },
                    { 27, 0, "PE", "This course is a continuation of PE 181, which is an introduction to Hatha Yoga (the Yoga of physical well-being). Active participation and emphasis on awareness and internal focus while practicing advanced yoga asanas (poses), pranayama (controlled breath), and meditation. Performance of these skills and techniques will increase muscle strength and endurance, increase flexibility and balance, improve body posture, reduce stress, and enhance relaxation. Prerequisite: PE 181.", 0, "182", "Yoga II (All Levels/Intermediate)" },
                    { 11, 0, "IS", "Internet Fundamentals provides practical information regarding Internet practices and safety. Searching, validating, and securely passing information to and from the Internet are emphasized. Identifying and mitigating common threats such as spyware, viruses, Trojan Horses, and identity theft are covered. Prerequisites: Reading Proficiency.", 0, "136", "Internet Fundamentals" },
                    { 10, 3, "IS", "Hardware Support - CompTIA A+ Core 1 (Hardware) covers the theory and hands-on skills necessary to pass the CompTIA A+ hardware (Core 1) exam. Topics covered include hardware fundamentals, networking, and security. Students will learn basic operating system functionality and troubleshooting methodology, the practice of proper safety procedures, and how to effectively interact with customers and co-workers. Recommended Preparation: Basic computer literacy is expected. Prerequisite: Reading Proficiency.", 3, "130", "Hardware Support - CompTIA A+ Core 1 (Hardware)" },
                    { 9, 0, "IS", "HTML covers the essentials of creating web pages using Hypertext Markup Language (HTML) and Cascading Style Sheets (CSS). Students will create and edit web pages which include text, hyperlinks, images, and tables. HTML and CSS will be used to control page appearance and layout. Recommended preparation IS 123 or equivalent experience. Prerequisite: Reading Proficiency.", 0, "129", "HTML" },
                    { 8, 0, "IS", "Students learn the basic concepts of the Windows environment and how to create and manage files within the organizational structure of that environment. The desktop, accessories, and navigational tools will also be covered.", 0, "123", "Introduction to Windows" },
                    { 7, 3, "IS", "Windows is a skill-development course covering the Microsoft Windows operating system. Topics include file and folder management and organization, hardware management, software management, network connection, system customization, system optimization, and system security. Prerequisite: Reading Proficiency.", 3, "122", "Windows" },
                    { 6, 0, "IS", "Introduction to Excel teaches the fundamentals of creating and managing Excel worksheets and workbooks. Topics include creating cells and ranges, creating tables, applying formulas and functions, and creating basic charts and objects to represent data visually. Prerequisites: Reading Proficiency.", 0, "120", "Introduction to Excel" },
                    { 5, 3, "IS", "This course explores the terminology and concepts of computers including file management, Internet browsers, and web page development. Students gain proficiency using productivity tools such as word processors, presentation software, electronic spreadsheets and electronic mail to solve problems, communicate, and manage information to make informed decisions. Students will also develop a computer application. Prerequisite: Reading Proficiency.", 3, "116", "Computer Literacy" },
                    { 4, 3, "IS", "Software and Hardware Architecture provides a survey of technical topics related to computer systems with emphasis on the relationships between hardware architecture and systems software. Binary and hexadecimal number systems, data representation, data structures, processor architecture, and operating systems functions and methods will be explored. Recommended Preparation: Basic computer literacy is expected. Prerequisites: MTH 160 or MTH 180 (can be taken concurrently), and Reading Proficiency.", 3, "112", "Software and Hardware Architecture" },
                    { 3, 0, "IS", "Students learn to produce high-quality business communications through proofreading for accuracy in mechanics, format, and content as well as edit documents for correctness, conciseness, and clarity. Prerequisites: IS 101 or IS 102 and Reading Proficiency.", 0, "109", "Proofreading and Editing" },
                    { 2, 3, "IS", "Keyboarding and Formatting is a skill-development course in which students utilize proper techniques to develop touch control of the keyboard and apply basic formatting skills to letters, memos, reports, and tables.", 3, "102", "Keyboarding and Formatting" },
                    { 1, 0, "IS", "Keyboarding is a skill-development course designed to introduce touch control of the keyboard using proper techniques. Emphasis is on learning the alphabetic, numeric, and symbol keys. Students learn basic techniques to build speed and accuracy. Satisfactory/Unsatisfactory grading.", 0, "101", "Keyboarding" },
                    { 13, 3, "IS", "Web Development I is an in-depth study of the development and implementation of engaging websites using current industry production tools. Accessibility, security, and website management issues will be addressed. Topics such as file formats, platform standards, user-centered navigation, dynamic content such as streaming video/audio, and search engine concepts will be presented. Prerequisites: IS 187 or IS 153, IS 139, IS 265 and Reading Proficiency.", 3, "142", "Web Development I" },
                    { 28, 0, "PE", "This course is designed to prepare students in healthcare professions with basic life support and cardiopulmonary resuscitation (CPR). Students will learn how to recognize cardiac arrest, give chest compressions, deliver ventilations, and provide early use of an automated external defibrillator (AED) individually and with a partner. Adult, child, and infant rescue techniques including choking will be part of this course. American Heart Association Basic Life Support (BLS) for Healthcare Providers certification is available for those who meet the course requirements. Additional fee is required to obtain certification. Prerequisite: Reading Proficiency.", 0, "220", "American Heart Association Cardiopulmonary Resuscitation (CPR) for Healthcare Providers" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "ID", "CampusID", "Department", "Email", "FirstName", "LastName", "MiddleName", "Phone" },
                values: new object[,]
                {
                    { 17, 1, "", "", "STLCC", "Staff", "", "" },
                    { 20, 4, "PE", "vpaez@stlcc.edu", "V", "Paez", "SuzAnne", "314-984-7399" },
                    { 19, 4, "PE", "adattoli@stlcc.edu", "Anthony", "Dattoli", "David", "314-984-7785" },
                    { 18, 4, "IS", "ttumulty@stlcc.edu", "Tevis", "Tumulty", "N", "Not available" },
                    { 16, 4, "IS", "ghe1@stlcc.edu", "Guangrong", "He", "", "Not available" },
                    { 15, 4, "IS", "sccalicutt@stlcc.edu", "Stevie", "Calicutt", "C", "314-984-7519" },
                    { 13, 4, "IS", "ltroxler@stlcc.edu", "Lisa", "Troxler", "Marie", "Not available" },
                    { 12, 4, "IS", "jmercer@stlcc.edu", "June", "Mercer", "J", "314-984-7531" },
                    { 4, 4, "IS", "mhvatum@stlcc.edu", "Margaret", "Hvatum", "M", "314-984-7518" },
                    { 28, 3, "PE", "bbogosian@stlcc.edu", "Bethany", "Bogosian", "Jo", "Not available" },
                    { 26, 3, "PE", "dlim3@stlcc.edu", "Dowon", "Lim", "", "Not available" },
                    { 25, 3, "PE", "jcarter308@stlcc.edu", "Joshua", "Carter", "A", "Not available" },
                    { 21, 3, "PE", "mapplegate2@stlcc.edu", "Mark", "Applegate", "D", "Not available" },
                    { 23, 4, "PE", "methridge1@stlcc.edu", "Michelle", "Ethridge", "Rene", "314-984-7485" },
                    { 14, 3, "IS", "whocker@stlcc.edu", "William", "Hocker", "D", "314-644-9084" },
                    { 10, 3, "IS", "troesslein1@stlcc.edu", "Timothy", "Roesslein", "J", "314-644-9273" },
                    { 9, 3, "IS", "tgrote@stlcc.edu", "Terri", "Grote", "J", "314-644-9078" },
                    { 7, 3, "IS", "cchott@stlcc.edu", "Craig", "Chott", "S", "314-644-9298" },
                    { 6, 3, "IS", "fdarris@stlcc.edu", "Francelle", "Darris", "V", "314-644-9082" },
                    { 5, 3, "IS", "gadamecz@stlcc.edu	", "Gustav", "Adamecz", "", "314-644-9296" },
                    { 27, 2, "BIO", "mmanteuffel@stlcc.edu", "Mark", "Manteuffel", "Steven", "314-513-4632" },
                    { 24, 2, "PE", "wbryan@stlcc.edu", "Wayne", "Bryan", "M", "Not available" },
                    { 22, 2, "PE", "mdutt@stlcc.edu", "Michael", "Dutt", "D", "314-513-4275" },
                    { 8, 2, "IS", "pdavis@stlcc.edu", "Phyllis", "Davis", "Regina", "314-513-4042" },
                    { 3, 2, "LS", "jfurlong11@stlcc.edu", "John", "Furlong", "T", "314-513-4702" },
                    { 2, 2, "IS", "ddoering7@stlcc.edu", "David", "Doering", "A", "314-513-4511" },
                    { 1, 2, "BA", "shollins4@stlcc.edu", "Stacy", "Hollins", "Gee", "Not available" },
                    { 11, 3, "IS", "ccalicutt@stlcc.edu", "Carolyn", "Calicutt", "J", "314-644-9273" },
                    { 29, 5, "PE", "lhartin@stlcc.edu", "Liesa", "Hartin", "A", "636-422-2200" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "Building", "CRN", "CampusID", "CourseID", "EndDate", "InstructorID", "Notes", "Number", "Room", "ScheduleType", "Seats", "StartDate", "StudentsEnrolled", "Type" },
                values: new object[,]
                {
                    { 42, null, 31614, 1, 15, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Web-Based / Internet" },
                    { 60, null, 31286, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "232", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Web-Based / Internet" },
                    { 45, null, 30825, 1, 17, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class.", "601", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Live Virtual Lecture" },
                    { 44, null, 31263, 1, 16, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, null, "650", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Live Virtual Lecture" },
                    { 43, null, 31262, 1, 16, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, null, "601", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Live Virtual Lecture" },
                    { 37, null, 34089, 1, 12, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null, "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, null },
                    { 35, null, 31545, 1, 12, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, null, "695", null, "Hybrid", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Live Virtual Lecture" },
                    { 31, null, 33094, 1, 10, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.", "601", null, "Hybrid", 12, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Live Virtual Lecture" },
                    { 18, null, 32173, 1, 5, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 36, null, 31159, 1, 12, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 17, null, 31283, 1, 5, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "211", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 22, null, 33550, 1, 6, new DateTime(2020, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "602", null, "Online", 25, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Live Virtual Lecture" },
                    { 21, null, 33549, 1, 6, new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "601", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Live Virtual Lecture" },
                    { 5, null, 30250, 1, 4, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, "601", null, "Online", 24, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Live Virtual Lecture" },
                    { 95, null, 30874, 1, 27, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Hatha Yoga (the Yoga of physical wellbeing) is taught. Designed for students of all physical conditions. Tones and limbers the body, reduces the effects of everyday physical and mental strain. Written observations included in course requirements.", "604", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Live Virtual Lecture" },
                    { 94, null, 31464, 1, 27, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null, "602", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Live Virtual Lecture" },
                    { 86, null, 30749, 1, 26, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Introduction to Hatha Yoga (the Yoga of physical wellbeing). Designed for students of all physical conditions. Tones and limbers the body, reduces the effects of everyday physical and mental strain. Written observations included in course requirements.", "604", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Live Virtual Lecture" },
                    { 85, null, 30013, 1, 26, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, null, "602", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Live Virtual Lecture" },
                    { 84, null, 33475, 1, 26, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "This class is strictly for STLCC athletes.", "601", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Live Virtual Lecture" },
                    { 71, null, 30011, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "This course will focus on body weight exercises for strength development.", "603", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Live Virtual Lecture" },
                    { 69, null, 32434, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "This course will focus on body weight exercises for strength development.", "601", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Live Virtual Lecture" },
                    { 59, null, 32157, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "231", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Web-Based / Internet" },
                    { 64, null, 30834, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "301", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 66, null, 30009, 1, 22, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null, "650", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Live Virtual Lecture" },
                    { 70, null, 30010, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This course will focus on body weight exercises for strength development.", "602", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Live Virtual Lecture" },
                    { 72, null, 33166, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This course is restricted for the STLCC Baseball players. This course will focus on body weight exercises for strength development.", "604", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Live Virtual Lecture" },
                    { 97, null, 31603, 5, 27, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class.", "350", null, "Activity-Based", 20, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Class" },
                    { 96, null, 30015, 5, 27, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class.", "340", null, "Activity-Based", 20, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Class" },
                    { 92, null, 31078, 1, 26, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "486", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Web-Based / Internet" },
                    { 91, null, 31235, 1, 26, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "403", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Web-Based / Internet" },
                    { 90, null, 31234, 1, 26, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "402", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Web-Based / Internet" },
                    { 89, null, 30854, 1, 26, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "401", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Web-Based / Internet" },
                    { 88, null, 31602, 5, 26, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class.", "350", null, "Activity-Based", 20, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Class" },
                    { 87, null, 30014, 5, 26, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                Students who enroll in this class will need to sign a liability waiver on or before the 1st day of class.", "340", null, "Activity-Based", 20, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Class" },
                    { 57, null, 33433, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "213", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 56, null, 33432, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "212", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 100, "Physical Ed Bldg TB", 31623, 3, 28, new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                There is an additional fee of $10.00 for students wishing to purchase the AHA certification card.", "490", "A", "Hybrid", 9, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "In-Class/Online/Virtual Lect." },
                    { 54, null, 30005, 1, 21, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, null, "601", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Live Virtual Lecture" },
                    { 51, null, 31317, 1, 20, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "220", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 46, "Physical Educ Bldg", 31672, 4, 18, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                This is a hybrid class. Students are expected to participate in online course work and attend class on 10/24 or 10/31 for a 2 hour class session. The date/time will be arranged by the instructor on the first day of class. There is a $19 course fee for certification.", "695", "201", "Hybrid", 8, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Class" },
                    { 81, null, 31193, 1, 25, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Web-Based / Internet" },
                    { 80, null, 30743, 1, 25, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "220", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Web-Based / Internet" },
                    { 78, null, 33165, 1, 25, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, null, "601", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Live Virtual Lecture" },
                    { 77, null, 33605, 1, 24, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This course will focus on body weight exercises for strength development.", "606", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "Live Virtual Lecture" },
                    { 76, null, 33173, 1, 24, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "Students who enroll in this class will need to sign a liability waiver on or before the first day of class. This class is specifically for STLCC Softball players. This course will focus on body weight exercises for strength development.", "605", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Live Virtual Lecture" },
                    { 75, null, 33171, 1, 24, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This course is restricted for the baseball team. This course will focus on body weight exercises for strength development.", "604", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Live Virtual Lecture" },
                    { 74, null, 33170, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This class is specifically for the STLCC Baseball players. Students who enroll in this class will need to sign a liability waiver on or before the first day of class. This course will focus on body weight exercises for strength development.", "606", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Live Virtual Lecture" },
                    { 73, null, 33168, 1, 23, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "This course is restricted for STLCC Softball players. This course will focus on body weight exercises for strength development.", "605", null, "Online", 30, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Live Virtual Lecture" },
                    { 52, null, 31316, 1, 20, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 98, null, 30725, 1, 27, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "401", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Web-Based / Internet" },
                    { 82, null, 33436, 1, 25, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "240", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Web-Based / Internet" },
                    { 68, null, 34057, 1, 22, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, null, "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, null },
                    { 55, null, 30986, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 67, null, 33803, 1, 22, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "201", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 49, null, 33503, 1, 19, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "550", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 48, null, 31519, 1, 18, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "570", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 41, null, 31575, 1, 14, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "220", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Web-Based / Internet" },
                    { 40, null, 30976, 1, 14, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Web-Based / Internet" },
                    { 25, null, 30722, 1, 8, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "220", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 12, "Business Bldg", 33509, 2, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.", "502", "125", "Hybrid", 9, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "In-Class/Online/Virtual Lect." },
                    { 11, "Business Bldg", 33508, 2, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.", "501", "125", "Hybrid", 9, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "In-Class/Online/Virtual Lect." },
                    { 4, null, 31727, 1, 3, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Web-Based / Internet" },
                    { 39, null, 33077, 1, 13, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "450", null, "Hybrid", 18, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Live Virtual Lecture" },
                    { 38, null, 33412, 1, 12, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "240", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 34, null, 33076, 1, 12, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "450", null, "Hybrid", 25, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Live Virtual Lecture" },
                    { 32, "Business Bldg", 32667, 2, 11, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "501", "122", "Online", 9, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Live Virtual Lecture" },
                    { 28, null, 30787, 1, 9, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Web-Based / Internet" },
                    { 23, null, 31576, 1, 7, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 3, null, 30757, 1, 2, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "Web-Based / Internet" },
                    { 2, "Business Bldg", 33506, 2, 2, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.", "502", "122", "Hybrid", 9, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "In-Class/Online/Virtual Lect." },
                    { 19, null, 33411, 1, 5, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "240", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 7, null, 31736, 1, 4, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 1, null, 30784, 1, 1, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "220", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 58, null, 31187, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 61, null, 31752, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "233", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Web-Based / Internet" },
                    { 62, null, 31440, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "235", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 65, null, 30770, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "501", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 63, null, 33434, 1, 21, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "240", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 53, null, 33431, 1, 20, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "240", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 50, null, 31742, 1, 20, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 47, null, 32547, 1, 18, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, null, "490", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Web-Based / Internet" },
                    { 30, null, 32634, 1, 10, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, "451", null, "Hybrid", 15, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Live Virtual Lecture" },
                    { 29, null, 30975, 1, 10, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, null, "450", null, "Hybrid", 15, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Live Virtual Lecture" },
                    { 16, null, 31030, 1, 5, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Web-Based / Internet" },
                    { 33, null, 33083, 1, 11, new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This course is restricted for BJC students. This is a hybrid class which will be held as Live Virtual Lecture. Students are expected to actively participate in the online activities. Students are expected to have access to a computer, internet connection, and basic software such as Microsoft Word. More information about being successful in online classes can be found at https://stlcc.edu/campus-life-community/our-locations/online-education/online-success-beginner.aspx", "450", null, "Hybrid", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Live Virtual Lecture" },
                    { 27, null, 30810, 1, 8, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "231", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 26, null, 30803, 1, 8, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "230", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "Web-Based / Internet" },
                    { 79, null, 31218, 1, 25, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "210", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "Web-Based / Internet" },
                    { 24, null, 32656, 1, 8, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This is an 8-week open-entry, self-paced course. The last day to register is October 14. Your instructor will e-mail via Blackboard prior to the start of the semester (or, after your registration if the semester has already begun) with important information.", "450", null, "Online", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Live Virtual Lecture" },
                    { 15, null, 31055, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, "650", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Live Virtual Lecture" },
                    { 13, null, 31370, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, null, "603", null, "Online", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Live Virtual Lecture" },
                    { 20, null, 31261, 1, 5, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, "601", null, "Online", 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Web-Based / Internet" },
                    { 10, null, 31477, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, null, "403", null, "Online", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Live Virtual Lecture" },
                    { 9, null, 31253, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, "402", null, "Online", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "Live Virtual Lecture" },
                    { 8, null, 31142, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, null, "401", null, "Online", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Live Virtual Lecture" },
                    { 6, null, 31737, 1, 4, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, null, "450", null, "Hybrid", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Live Virtual Lecture" },
                    { 93, null, 31034, 1, 27, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Students are required to bring one pair of dumbbells up to 5 lbs.", "502", null, "Online", 4, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Live Virtual Lecture" },
                    { 83, null, 33067, 1, 26, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, null, "501", null, "Online", 18, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Live Virtual Lecture" },
                    { 101, "Physical Ed Bldg", 32222, 2, 28, new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, @"Virtual class meetings in place of on-campus/on-site meetings may be necessary as we progress through the fall 2020 term.

                                There is an additional fee of $10.00 for students wishing to purchase their AHA certification card.", "501", "204", "Hybrid", 8, new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "In-Class/Online/Virtual Lect." },
                    { 14, null, 33082, 1, 5, new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "This course is restricted for BJC students. This is a hybrid class which will be held as Live Virtual Lecture. Students are expected to actively participate in the online activities. Students are expected to have access to a computer, internet connection, and basic software such as Microsoft Word. More information about being successful in online classes can be found at https://stlcc.edu/campus-life-community/our-locations/online-education/online-success-beginner.aspx", "450", null, "Hybrid", 25, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Live Virtual Lecture" },
                    { 99, null, 31236, 1, 27, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "This is an online class and students are expected to have access to a computer, stable internet connection, and basic software such as Microsoft Word. For courses designated as Live Virtual Lecture, students should plan to meet via webinar technologies (webcam and microphone required) on the specified dates/times.", "490", null, "Online", 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Web-Based / Internet" }
                });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "ID", "Building", "CampusID", "Day", "EndDate", "EndTime", "Room", "SectionID", "StartDate", "StartTime", "Type" },
                values: new object[,]
                {
                    { 63, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 42, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 48, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 21, 50, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 55, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 35, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 56, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 20, 0, 0, DateTimeKind.Unspecified), null, 35, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 64, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), null, 43, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 65, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), null, 43, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 66, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 10, 0, 0, DateTimeKind.Unspecified), null, 43, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 67, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 21, 40, 0, 0, DateTimeKind.Unspecified), null, 44, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 68, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), null, 45, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 69, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 35, 0, 0, DateTimeKind.Unspecified), null, 45, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 87, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 60, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 91, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 64, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 93, null, 1, "T", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 66, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 94, null, 1, "R", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 66, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 99, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 50, 0, 0, DateTimeKind.Unspecified), null, 70, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 100, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 50, 0, 0, DateTimeKind.Unspecified), null, 70, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 47, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 31, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 103, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 72, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 30, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 18, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 29, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 17, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 129, null, 1, "F", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 35, 0, 0, DateTimeKind.Unspecified), null, 84, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 130, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 50, 0, 0, DateTimeKind.Unspecified), null, 85, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 131, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 50, 0, 0, DateTimeKind.Unspecified), null, 85, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 132, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), null, 86, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 133, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), null, 86, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 141, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 50, 0, 0, DateTimeKind.Unspecified), null, 94, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 142, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 50, 0, 0, DateTimeKind.Unspecified), null, 94, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 143, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), null, 95, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 144, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 45, 0, 0, DateTimeKind.Unspecified), null, 95, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 6, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 7, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), null, 5, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 33, null, 1, "T", new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 34, null, 1, "R", new DateTime(2020, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 21, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 35, null, 1, "T", new DateTime(2020, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 36, null, 1, "R", new DateTime(2020, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 22, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 57, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 36, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 104, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 72, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 105, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 72, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 106, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 73, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 72, "Physical Educ Bldg", 4, "S", new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "201", 46, new DateTime(2020, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 77, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 51, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 78, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 52, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 80, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), null, 54, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 81, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 35, 0, 0, DateTimeKind.Unspecified), null, 54, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 83, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 56, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 84, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 57, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 134, null, 5, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 87, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 135, null, 5, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 88, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 15, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 136, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 89, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 137, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 90, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 138, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 91, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 139, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 92, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 145, null, 5, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), null, 96, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 146, null, 5, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 45, 0, 0, DateTimeKind.Unspecified), null, 97, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 15, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 71, "Physical Educ Bldg", 4, "S", new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "201", 46, new DateTime(2020, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "Class" },
                    { 70, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 46, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 125, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 81, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 124, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 80, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 107, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 73, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 108, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 73, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 109, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 74, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 110, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 74, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 111, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 74, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 112, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 75, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 113, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 75, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 128, null, 1, "W", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 35, 0, 0, DateTimeKind.Unspecified), null, 84, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 114, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 55, 0, 0, DateTimeKind.Unspecified), null, 75, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 116, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 76, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 117, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 76, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 118, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 77, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 119, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 77, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 120, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 7, 5, 0, 0, DateTimeKind.Unspecified), null, 77, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 6, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 121, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), null, 78, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 122, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 35, 0, 0, DateTimeKind.Unspecified), null, 78, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 115, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 5, 0, 0, DateTimeKind.Unspecified), null, 76, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 147, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 98, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 102, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), null, 71, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 98, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), null, 69, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 21, "Business Bldg", 2, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), "125", 12, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 39, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 25, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 61, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 40, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 62, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 41, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 74, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 48, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 75, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 49, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 95, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 67, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 82, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 55, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 85, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 58, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 88, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 61, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 89, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 62, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 92, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 65, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 152, "Physical Ed Bldg", 2, "S", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "204", 101, new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 153, "Physical Ed Bldg", 2, "U", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 0, 0, 0, DateTimeKind.Unspecified), "204", 101, new DateTime(2020, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 127, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), null, 83, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 20, "Business Bldg", 2, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), "125", 12, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 140, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 45, 0, 0, DateTimeKind.Unspecified), null, 93, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 19, "Business Bldg", 2, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), "125", 11, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 5, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 4, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 1, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 1, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 10, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 7, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 31, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 19, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 2, "Business Bldg", 2, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), "122", 2, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 3, "Business Bldg", 2, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 10, 0, 0, DateTimeKind.Unspecified), "122", 2, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 4, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 3, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 37, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 23, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 42, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 28, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 49, "Business Bldg", 2, "M", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 50, 0, 0, DateTimeKind.Unspecified), "122", 32, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 50, "Business Bldg", 2, "W", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 50, 0, 0, DateTimeKind.Unspecified), "122", 32, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 53, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 54, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 34, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 58, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 38, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 59, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 39, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 60, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 15, 0, 0, DateTimeKind.Unspecified), null, 39, new DateTime(2020, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 18, "Business Bldg", 2, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), "125", 11, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 8, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 9, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 45, 0, 0, DateTimeKind.Unspecified), null, 6, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 11, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 44, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 10, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 45, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 46, null, 1, "T", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 10, 0, 0, DateTimeKind.Unspecified), null, 30, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 73, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 47, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 76, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 50, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 79, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 53, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 90, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 63, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 123, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 79, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 126, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 82, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 149, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 100, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 150, "Physical Ed Bldg TB", 3, "T", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 55, 0, 0, DateTimeKind.Unspecified), "A", 100, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 151, "Physical Ed Bldg TB", 3, "R", new DateTime(2020, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 15, 55, 0, 0, DateTimeKind.Unspecified), "A", 100, new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "In-Class/Online/Virtual Lect." },
                    { 86, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 59, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 96, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), null, 69, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 97, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 5, 0, 0, DateTimeKind.Unspecified), null, 69, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 43, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 29, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 28, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 16, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 52, null, 1, "R", new DateTime(2020, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 20, 50, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 51, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 33, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 12, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 45, 0, 0, DateTimeKind.Unspecified), null, 8, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 9, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 13, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 14, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 15, 0, 0, DateTimeKind.Unspecified), null, 9, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 15, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 50, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 16, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 50, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 17, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 50, 0, 0, DateTimeKind.Unspecified), null, 10, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 32, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 20, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 101, null, 1, "T", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 13, 20, 0, 0, DateTimeKind.Unspecified), null, 71, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 12, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 22, null, 1, "M", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 50, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 24, null, 1, "F", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 50, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 27, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 21, 40, 0, 0, DateTimeKind.Unspecified), null, 15, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 25, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 26, null, 1, "R", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 19, 15, 0, 0, DateTimeKind.Unspecified), null, 14, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 38, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 18, 30, 0, 0, DateTimeKind.Unspecified), null, 24, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 40, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 26, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 41, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 27, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" },
                    { 23, null, 1, "W", new DateTime(2021, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 50, 0, 0, DateTimeKind.Unspecified), null, 13, new DateTime(2020, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Live Virtual Lecture" },
                    { 148, null, 1, null, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 1, 0, 0, DateTimeKind.Unspecified), null, 99, new DateTime(2020, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web-Based / Internet" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_SectionID",
                table: "CartItems",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_UserId",
                table: "CartItems",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledClasses_SectionID",
                table: "EnrolledClasses",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_EnrolledClasses_UserId",
                table: "EnrolledClasses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_CampusID",
                table: "Instructors",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CampusID",
                table: "Meetings",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_SectionID",
                table: "Meetings",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CampusID",
                table: "Sections",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseID",
                table: "Sections",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InstructorID",
                table: "Sections",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptItems_CourseID",
                table: "TranscriptItems",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_TranscriptItems_UserId",
                table: "TranscriptItems",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "EnrolledClasses");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropTable(
                name: "TranscriptItems");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Campuses");
        }
    }
}
