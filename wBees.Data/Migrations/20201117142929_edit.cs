using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_SubIndustryId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "SubIndustryId",
                table: "Jobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SubIndustryId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_SubIndustryId",
                table: "Jobs",
                column: "SubIndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs",
                column: "SubIndustryId",
                principalTable: "SubIndustries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
