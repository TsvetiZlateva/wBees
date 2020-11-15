using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class AddApplicantsToJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_ApplicantsId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_ApplicantsId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "ApplicantsId",
                table: "Jobs");

            migrationBuilder.AddColumn<Guid>(
                name: "JobId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Jobs_JobId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "ApplicantsId",
                table: "Jobs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_ApplicantsId",
                table: "Jobs",
                column: "ApplicantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_ApplicantsId",
                table: "Jobs",
                column: "ApplicantsId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
