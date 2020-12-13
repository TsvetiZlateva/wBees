using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class AddEmployerToJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Employer",
                table: "Jobs",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employer",
                table: "Jobs");
        }
    }
}
