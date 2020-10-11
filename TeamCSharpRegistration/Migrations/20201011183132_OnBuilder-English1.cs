using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class OnBuilderEnglish1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Courses",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LectureHours",
                table: "Courses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Number",
                table: "Courses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CreditHours", "Department", "Description", "LectureHours", "Number", "Title" },
                values: new object[,]
                {
                    { 1, 3, "ENG", "College Composition I focuses on the development of writing techniques. Students will develop effective writing styles, writing processes, revision practices, and analytical skills.", 3, "101", "College Composition I" },
                    { 2, 3, "ENG", "College Composition II builds on knowledge and skills learned in ENG 101 and primarily focuses on argumentative and persuasive writing techniques. Students will develop effective writing processes, writing styles, research abilities, analytical skills, and argumentative tools.", 3, "102", "College Composition II" },
                    { 3, 3, "ENG", "Report Writing builds on knowledge and skills learned in previous writing courses and primarily focuses on the development of writing techniques required in fields such as business, health science, technology, and engineering. Students will develop effective writing styles, writing processes, and analytical skills for business and technical writing.", 3, "103", "Report Writing" },
                    { 4, 3, "ENG", "Introduction to Fiction provides students with an understanding of short and long fiction. Students have the opportunity to study various forms and styles of fiction as well as the major themes and concepts presented within this genre.", 3, "201", "Introduction to Fiction" },
                    { 5, 3, "ENG", "American Literature II provides a survey of American literature from the Civil War to the present. This course includes the topics of literary criticism, textual reception, as well as historical and cultural context. Various authors and genres will be included.", 3, "205", "American Literature II" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "LectureHours",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "Courses");
        }
    }
}
