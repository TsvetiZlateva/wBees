﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class RemoveIndustryColumnFromJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs");

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs");

            migrationBuilder.AlterColumn<Guid>(
                name: "IndustryId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Industries_IndustryId",
                table: "Jobs",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
