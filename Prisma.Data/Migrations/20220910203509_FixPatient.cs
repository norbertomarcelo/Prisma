using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prisma.Data.Migrations
{
    public partial class FixPatient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AssessmentDate",
                table: "Patient",
                newName: "RegistrationDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Patient",
                type: "DATE",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Patient");

            migrationBuilder.RenameColumn(
                name: "RegistrationDate",
                table: "Patient",
                newName: "AssessmentDate");
        }
    }
}
