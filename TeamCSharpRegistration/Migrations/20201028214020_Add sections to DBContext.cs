using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class AddsectionstoDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Section_Campus_CampusID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Courses_CourseID",
                table: "Section");

            migrationBuilder.DropForeignKey(
                name: "FK_Section_Instructor_InstructorID",
                table: "Section");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Section",
                table: "Section");

            migrationBuilder.RenameTable(
                name: "Section",
                newName: "Sections");

            migrationBuilder.RenameIndex(
                name: "IX_Section_InstructorID",
                table: "Sections",
                newName: "IX_Sections_InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_Section_CourseID",
                table: "Sections",
                newName: "IX_Sections_CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Section_CampusID",
                table: "Sections",
                newName: "IX_Sections_CampusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sections",
                table: "Sections",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Campus_CampusID",
                table: "Sections",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Courses_CourseID",
                table: "Sections",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Instructor_InstructorID",
                table: "Sections",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Campus_CampusID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Courses_CourseID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instructor_InstructorID",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sections",
                table: "Sections");

            migrationBuilder.RenameTable(
                name: "Sections",
                newName: "Section");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_InstructorID",
                table: "Section",
                newName: "IX_Section_InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_CourseID",
                table: "Section",
                newName: "IX_Section_CourseID");

            migrationBuilder.RenameIndex(
                name: "IX_Sections_CampusID",
                table: "Section",
                newName: "IX_Section_CampusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Section",
                table: "Section",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Campus_CampusID",
                table: "Section",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Courses_CourseID",
                table: "Section",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Section_Instructor_InstructorID",
                table: "Section",
                column: "InstructorID",
                principalTable: "Instructor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
