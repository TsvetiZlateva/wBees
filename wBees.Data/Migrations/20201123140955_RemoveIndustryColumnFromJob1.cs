using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class RemoveIndustryColumnFromJob1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_IndustryId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Jobs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IndustryId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_IndustryId",
                table: "Jobs",
                column: "IndustryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
