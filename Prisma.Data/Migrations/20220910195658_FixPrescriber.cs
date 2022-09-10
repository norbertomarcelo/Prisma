using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prisma.Data.Migrations
{
    public partial class FixPrescriber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Coffito",
                table: "Prescriber",
                type: "NVARCHAR(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coffito",
                table: "Prescriber");
        }
    }
}
