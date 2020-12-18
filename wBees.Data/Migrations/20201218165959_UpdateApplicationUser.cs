using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class UpdateApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Interests",
                table: "AspNetUsers",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WantedSalary",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Interests",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WantedSalary",
                table: "AspNetUsers");
        }
    }
}
