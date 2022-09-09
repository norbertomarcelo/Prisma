using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prisma.Data.Migrations
{
    public partial class FixAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Address",
                type: "NVARCHAR(10)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Address",
                type: "INT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(10)");
        }
    }
}
