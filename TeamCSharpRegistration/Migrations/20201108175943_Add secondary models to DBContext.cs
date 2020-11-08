using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamCSharpRegistration.Migrations
{
    public partial class AddsecondarymodelstoDBContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Campus_CampusID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Campus_CampusID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instructor_InstructorID",
                table: "Sections");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campus",
                table: "Campus");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "Instructors");

            migrationBuilder.RenameTable(
                name: "Campus",
                newName: "Campuses");

            migrationBuilder.RenameIndex(
                name: "IX_Instructor_CampusID",
                table: "Instructors",
                newName: "IX_Instructors_CampusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campuses",
                table: "Campuses",
                column: "ID");

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

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_CampusID",
                table: "Meetings",
                column: "CampusID");

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_SectionID",
                table: "Meetings",
                column: "SectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Campuses_CampusID",
                table: "Instructors",
                column: "CampusID",
                principalTable: "Campuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Campuses_CampusID",
                table: "Sections",
                column: "CampusID",
                principalTable: "Campuses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Instructors_InstructorID",
                table: "Sections",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Campuses_CampusID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Campuses_CampusID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Instructors_InstructorID",
                table: "Sections");

            migrationBuilder.DropTable(
                name: "Meetings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructors",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Campuses",
                table: "Campuses");

            migrationBuilder.RenameTable(
                name: "Instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "Campuses",
                newName: "Campus");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_CampusID",
                table: "Instructor",
                newName: "IX_Instructor_CampusID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Campus",
                table: "Campus",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Campus_CampusID",
                table: "Instructor",
                column: "CampusID",
                principalTable: "Campus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Campus_CampusID",
                table: "Sections",
                column: "CampusID",
                principalTable: "Campus",
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
    }
}
