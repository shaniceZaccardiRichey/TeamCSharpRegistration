using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class ISCSharpModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[] { 6, 4, "IS", "Students in this course focus on completing the acquisition of the knowledge and skills for developing applications using Windows Forms, Windows Presentation Foundation (WPF) and the .NET Framework 4 in preparation for Microsoft's Microsoft Certified Technology Specialist (MCTS) .NET Framework 4, Windows Applications certification. Coursework will include developing Windows applications using the C# programming language to access data in Windows forms applications, create Windows services, utilize advanced user interface techniques, implement n-tier applications and implement web applications.", 4, "283", "C# Programming III" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[] { 7, 4, "IS", "C# Programming II focuses on broadening and deepening the student's understanding of Object Oriented Programming (OOP) as implemented in the C# language. Core elements include creating and deploying Windows programs, form application basics, building user interfaces using basic techniques, .NET fundamentals, basic coding within the .NET framework, design and development of classes, overloading and overriding methods and constructors, inheritance, encapsulation, and interfaces. Course objectives align with the Microsoft Certified Technical Specialist (MCTS) .NET Framework, Windows Applications certification.", 4, "253", "C# Programming II" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[] { 8, 4, "IS", "This course emphasizes software development problem-solving methodologies utilizing current software design and development tools and techniques. Topics include data structures, program design, pseudocode, language control structures, procedures and functions, error handling and Object Oriented design using classes. Assignments will be developed in the C# language using the current development environment.", 4, "153", "C# Programming I" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 8);
        }
    }
}
