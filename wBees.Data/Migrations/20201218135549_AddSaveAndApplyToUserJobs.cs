using Microsoft.EntityFrameworkCore.Migrations;

namespace wBees.Data.Migrations
{
    public partial class AddSaveAndApplyToUserJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_JobKeywords_Jobs_JobId",
                table: "JobKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_JobKeywords_Keywords_KeywordId",
                table: "JobKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_EmploymentTypes_EmploymentTypeId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Locations_LocationId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_SeniorityLevels_SeniorityLevelId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_SubIndustries_Industries_IndustryId",
                table: "SubIndustries");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_AspNetUsers_UserId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Jobs_JobId",
                table: "UserJobs");

            migrationBuilder.AddColumn<bool>(
                name: "Applied",
                table: "UserJobs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Saved",
                table: "UserJobs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobKeywords_Jobs_JobId",
                table: "JobKeywords",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobKeywords_Keywords_KeywordId",
                table: "JobKeywords",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_EmploymentTypes_EmploymentTypeId",
                table: "Jobs",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Locations_LocationId",
                table: "Jobs",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_SeniorityLevels_SeniorityLevelId",
                table: "Jobs",
                column: "SeniorityLevelId",
                principalTable: "SeniorityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs",
                column: "SubIndustryId",
                principalTable: "SubIndustries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubIndustries_Industries_IndustryId",
                table: "SubIndustries",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_AspNetUsers_UserId",
                table: "UserJobs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Jobs_JobId",
                table: "UserJobs",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_JobKeywords_Jobs_JobId",
                table: "JobKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_JobKeywords_Keywords_KeywordId",
                table: "JobKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_EmploymentTypes_EmploymentTypeId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Locations_LocationId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_SeniorityLevels_SeniorityLevelId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_SubIndustries_Industries_IndustryId",
                table: "SubIndustries");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_AspNetUsers_UserId",
                table: "UserJobs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserJobs_Jobs_JobId",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "Applied",
                table: "UserJobs");

            migrationBuilder.DropColumn(
                name: "Saved",
                table: "UserJobs");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobKeywords_Jobs_JobId",
                table: "JobKeywords",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobKeywords_Keywords_KeywordId",
                table: "JobKeywords",
                column: "KeywordId",
                principalTable: "Keywords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_EmploymentTypes_EmploymentTypeId",
                table: "Jobs",
                column: "EmploymentTypeId",
                principalTable: "EmploymentTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Locations_LocationId",
                table: "Jobs",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_SeniorityLevels_SeniorityLevelId",
                table: "Jobs",
                column: "SeniorityLevelId",
                principalTable: "SeniorityLevels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_SubIndustries_SubIndustryId",
                table: "Jobs",
                column: "SubIndustryId",
                principalTable: "SubIndustries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubIndustries_Industries_IndustryId",
                table: "SubIndustries",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_AspNetUsers_UserId",
                table: "UserJobs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserJobs_Jobs_JobId",
                table: "UserJobs",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
