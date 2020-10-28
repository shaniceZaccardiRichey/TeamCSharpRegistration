using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class DBreset : Migration
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
                name: "Campus",
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
                    table.PrimaryKey("PK_Campus", x => x.ID);
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
                    LectureHours = table.Column<int>(nullable: false)
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
                name: "Instructor",
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
                    table.PrimaryKey("PK_Instructor", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Instructor_Campus_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Sections_Campus_CampusID",
                        column: x => x.CampusID,
                        principalTable: "Campus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Campus",
                columns: new[] { "ID", "Address", "Code", "Name", "Phone" },
                values: new object[] { 1, "online", "ONL", "Online", "" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[,]
                {
                    { 20, 3, "IS", "Web Publishing introduces current industry standards for web development and design techniques that include the use of Hypertext Markup Language (HTML), Cascading Style Sheets (CSS), and an introduction to JavaScript. Topics such as web development process, accessibility standards, platform standards, HTML editors and converters, Web 2.0 Technologies, performance issues, tables, forms, dynamic content, and web site management issues will be presented. Prerequisite: Reading Proficiency.", 3, "139", "Web Publishing" },
                    { 21, 3, "IS", "Web Development I is an in-depth study of the development and implementation of engaging websites using current industry production tools. Accessibility, security, and website management issues will be addressed. Topics such as file formats, platform standards, user-centered navigation, dynamic content such as streaming video/audio, and search engine concepts will be presented. Prerequisites: IS 187 or IS 153, IS 139, IS 265 and Reading Proficiency.", 3, "142", "Web Development I" },
                    { 22, 0, "IS", "This course covers software programs frequently used in the business environment. Word processing, spreadsheets, database management, and presentation software will be introduced. Prerequisites: IS 122 or IS 123 or IT 102 or equivalent experience.", 0, "151", "Computer Applications in Business" },
                    { 23, 3, "IS", "This class is a continuation of Computer Applications in Business (IS 151). Software packages from these categories will be studied: spreadsheets, database management, word processing, and presentation software. Prerequisites: IS 151 and Reading Proficiency.", 3, "152", "Computer Applications in Business-Intermediate" },
                    { 24, 0, "IS", "This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment. Prerequisite: Reading Proficiency.", 0, "153", "C# Programming I" },
                    { 25, 0, "PE", "This course is an introductory course that focuses on fitness principles and exercise techniques used to develop strength, muscular endurance, flexibility, and cardio-respiratory fitness. A variety of physical activities and exercises will be introduced.", 0, "109", "Basic Fitness I" },
                    { 26, 0, "PE", "This course provides physiological principles of cardio-pulmonary functions with practical application in administering this lifesaving technique and use of an automated external defibrillator. Certification through the American Red Cross adult, child and infant Cardiopulmonary Resuscitation (CPR) and Automated External Defibrillation (AED) available for those who meet course requirements. Addition fee is required to obtain certification.", 0, "120", "Community Red Cross CPR" },
                    { 27, 0, "PE", "This course includes emergency recognition and first aid treatment for sudden illness and injuries with adult cardiopulmonary resuscitation (CPR) and automated external defibrillator (AED). First Aid and CPR/AED certification is available through the one of the following certifying agencies: American Red Cross, National Safety Council, or American Heart Association. This course may be taken to satisfy one credit hour of the physical education requirement. Prerequisite: Reading Proficiency.", 0, "129", "First Aid" },
                    { 28, 3, "PE", "This is an introduction to the concept of health being a foundation for positive movement throughout the life cycle. The course will explore the inter-relatedness of the body systems, the nature and communication of disease and the recovery process. Course topics will include healthy eating, fitness, sexuality, drugs, stress, and wellness. Prerequisite: Reading Proficiency.", 3, "135", "Health and Personal Hygiene" },
                    { 29, 3, "PE", "This course includes an overview of stress and its impact on physical, mental, emotional, and spiritual health and wellness. Coping strategies, relaxation techniques, healthy eating behaviors, and physical activities for stress reduction will be explored. Prerequisite: Reading Proficiency.", 3, "161", "Stress Management" },
                    { 30, 0, "PE", "This course focuses on the proper technique and attire, and the importance of cardiovascular fitness, weight control, and safety.", 0, "173", "Walking for Fitness" },
                    { 31, 0, "PE", "This course is designed to introduce the beginner to a variety of basic weight training skills. Techniques focus on safe execution of weight lifting using pin-select weight equipment and free weights to develop strength, size, endurance, and flexibility of major muscle groups. Circuit training is introduced.", 0, "177", "Weight Training I" },
                    { 32, 0, "PE", "This course focuses on advanced weight lifting techniques utilizing pin-select machines and free weights. Advanced level training programs for increased muscular development are designed. Circuit training is utilized. Prerequisite: PE 177 with a minimum grade of 'C'.", 0, "178", "Weight Training II" },
                    { 33, 3, "PE", "This course focuses on the impact physical activity, healthy eating behaviors, weight management, stress management, substance abuse, sexually transmitted diseases and other relevant topics have on health and wellness. The development of an individualized wellness program enhances understanding of course concepts. Additional hours required. Prerequisite: Reading Proficiency.", 3, "180", "Wellness and Fitness Concepts" },
                    { 34, 0, "PE", "This course is an introduction to Hatha Yoga (the Yoga of physical wellbeing), which includes basic poses (asanas), breathing techniques, meditation, and yoga philosophy. Active participation in these activities is designed to increase flexibility and balance, strengthen and tone muscles, and energize the body to reduce stress and enhance physical and mental health.", 0, "181", "Yoga I (Beginning)" },
                    { 19, 0, "IS", "Internet Fundamentals provides practical information regarding Internet practices and safety. Searching, validating, and securely passing information to and from the Internet are emphasized. Identifying and mitigating common threats such as spyware, viruses, Trojan Horses, and identity theft are covered. Prerequisites: Reading Proficiency.", 0, "136", "Internet Fundamentals" },
                    { 35, 0, "PE", "This course is a continuation of PE 181, which is an introduction to Hatha Yoga (the Yoga of physical well-being). Active participation and emphasis on awareness and internal focus while practicing advanced yoga asanas (poses), pranayama (controlled breath), and meditation. Performance of these skills and techniques will increase muscle strength and endurance, increase flexibility and balance, improve body posture, reduce stress, and enhance relaxation. Prerequisite: PE 181.", 0, "182", "Yoga II (All Levels/Intermediate)" },
                    { 18, 3, "IS", "Hardware Support - CompTIA A+ Core 1 (Hardware) covers the theory and hands-on skills necessary to pass the CompTIA A+ hardware (Core 1) exam. Topics covered include hardware fundamentals, networking, and security. Students will learn basic operating system functionality and troubleshooting methodology, the practice of proper safety procedures, and how to effectively interact with customers and co-workers. Recommended Preparation: Basic computer literacy is expected. Prerequisite: Reading Proficiency.", 3, "130", "Hardware Support - CompTIA A+ Core 1 (Hardware)" },
                    { 16, 0, "IS", "Students learn the basic concepts of the Windows environment and how to create and manage files within the organizational structure of that environment. The desktop, accessories, and navigational tools will also be covered.", 0, "123", "Introduction to Windows" },
                    { 1, 3, "ENG", "College Composition I focuses on the development of writing techniques. Students will develop effective writing styles, writing processes, revision practices, and analytical skills.", 3, "101", "College Composition I" },
                    { 2, 3, "ENG", "College Composition II builds on knowledge and skills learned in ENG 101 and primarily focuses on argumentative and persuasive writing techniques. Students will develop effective writing processes, writing styles, research abilities, analytical skills, and argumentative tools.", 3, "102", "College Composition II" },
                    { 3, 3, "ENG", "Report Writing builds on knowledge and skills learned in previous writing courses and primarily focuses on the development of writing techniques required in fields such as business, health science, technology, and engineering. Students will develop effective writing styles, writing processes, and analytical skills for business and technical writing.", 3, "103", "Report Writing" },
                    { 4, 3, "ENG", "Introduction to Fiction provides students with an understanding of short and long fiction. Students have the opportunity to study various forms and styles of fiction as well as the major themes and concepts presented within this genre.", 3, "201", "Introduction to Fiction" },
                    { 5, 3, "ENG", "American Literature II provides a survey of American literature from the Civil War to the present. This course includes the topics of literary criticism, textual reception, as well as historical and cultural context. Various authors and genres will be included.", 3, "205", "American Literature II" },
                    { 6, 4, "IS", "Students in this course focus on completing the acquisition of the knowledge and skills for developing applications using Windows Forms, Windows Presentation Foundation (WPF) and the .NET Framework 4 in preparation for Microsoft's Microsoft Certified Technology Specialist (MCTS) .NET Framework 4, Windows Applications certification. Coursework will include developing Windows applications using the C# programming language to access data in Windows forms applications, create Windows services, utilize advanced user interface techniques, implement n-tier applications and implement web applications.", 4, "283", "C# Programming III" },
                    { 7, 4, "IS", "C# Programming II focuses on broadening and deepening the student's understanding of Object Oriented Programming (OOP) as implemented in the C# language. Core elements include creating and deploying Windows programs, form application basics, building user interfaces using basic techniques, .NET fundamentals, basic coding within the .NET framework, design and development of classes, overloading and overriding methods and constructors, inheritance, encapsulation, and interfaces. Course objectives align with the Microsoft Certified Technical Specialist (MCTS) .NET Framework, Windows Applications certification.", 4, "253", "C# Programming II" },
                    { 8, 4, "IS", "This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment.", 4, "153", "C# Programming I" },
                    { 9, 0, "IS", "Keyboarding is a skill-development course designed to introduce touch control of the keyboard using proper techniques. Emphasis is on learning the alphabetic, numeric, and symbol keys. Students learn basic techniques to build speed and accuracy. Satisfactory/Unsatisfactory grading.", 0, "101", "Keyboarding" },
                    { 10, 3, "IS", "Keyboarding and Formatting is a skill-development course in which students utilize proper techniques to develop touch control of the keyboard and apply basic formatting skills to letters, memos, reports, and tables.", 3, "102", "Keyboarding and Formatting" },
                    { 11, 0, "IS", "Students learn to produce high-quality business communications through proofreading for accuracy in mechanics, format, and content as well as edit documents for correctness, conciseness, and clarity. Prerequisites: IS 101 or IS 102 and Reading Proficiency.", 0, "109", "Proofreading and Editing" },
                    { 12, 3, "IS", "Software and Hardware Architecture provides a survey of technical topics related to computer systems with emphasis on the relationships between hardware architecture and systems software. Binary and hexadecimal number systems, data representation, data structures, processor architecture, and operating systems functions and methods will be explored. Recommended Preparation: Basic computer literacy is expected. Prerequisites: MTH 160 or MTH 180 (can be taken concurrently), and Reading Proficiency.", 3, "112", "Software and Hardware Architecture" },
                    { 13, 3, "IS", "This course explores the terminology and concepts of computers including file management, Internet browsers, and web page development. Students gain proficiency using productivity tools such as word processors, presentation software, electronic spreadsheets and electronic mail to solve problems, communicate, and manage information to make informed decisions. Students will also develop a computer application. Prerequisite: Reading Proficiency.", 3, "116", "Computer Literacy" },
                    { 14, 0, "IS", "Introduction to Excel teaches the fundamentals of creating and managing Excel worksheets and workbooks. Topics include creating cells and ranges, creating tables, applying formulas and functions, and creating basic charts and objects to represent data visually. Prerequisites: Reading Proficiency.", 0, "120", "Introduction to Excel" },
                    { 15, 3, "IS", "Windows is a skill-development course covering the Microsoft Windows operating system. Topics include file and folder management and organization, hardware management, software management, network connection, system customization, system optimization, and system security. Prerequisite: Reading Proficiency.", 3, "122", "Windows" },
                    { 17, 0, "IS", "HTML covers the essentials of creating web pages using Hypertext Markup Language (HTML) and Cascading Style Sheets (CSS). Students will create and edit web pages which include text, hyperlinks, images, and tables. HTML and CSS will be used to control page appearance and layout. Recommended preparation IS 123 or equivalent experience. Prerequisite: Reading Proficiency.", 0, "129", "HTML" },
                    { 36, 0, "PE", "This course is designed to prepare students in healthcare professions with basic life support and cardiopulmonary resuscitation (CPR). Students will learn how to recognize cardiac arrest, give chest compressions, deliver ventilations, and provide early use of an automated external defibrillator (AED) individually and with a partner. Adult, child, and infant rescue techniques including choking will be part of this course. American Heart Association Basic Life Support (BLS) for Healthcare Providers certification is available for those who meet the course requirements. Additional fee is required to obtain certification. Prerequisite: Reading Proficiency.", 0, "220", "American Heart Association Cardiopulmonary Resuscitation (CPR) for Healthcare Providers" }
                });

            migrationBuilder.InsertData(
                table: "Instructor",
                columns: new[] { "ID", "CampusID", "Department", "Email", "FirstName", "LastName", "MiddleName", "Phone" },
                values: new object[] { 1, 1, "IS", "dyezbick@stlcc.edu", "Daniel", "Yezbick", null, "314-123-4567" });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "ID", "Building", "CRN", "CampusID", "CourseID", "EndDate", "InstructorID", "Notes", "Number", "Room", "ScheduleType", "Seats", "StartDate", "StudentsEnrolled", "Type" },
                values: new object[] { 1, "", 283746, 1, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "", "111", "", "Online", 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Online" });

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
                name: "IX_Instructor_CampusID",
                table: "Instructor",
                column: "CampusID");

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
                name: "Sections");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Instructor");

            migrationBuilder.DropTable(
                name: "Campus");
        }
    }
}
