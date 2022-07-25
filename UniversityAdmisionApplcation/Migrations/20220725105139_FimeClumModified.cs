using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityAdmisionApplcation.Migrations
{
    public partial class FimeClumModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "File",
                table: "Registration",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "File",
                table: "Registration");
        }
    }
}
