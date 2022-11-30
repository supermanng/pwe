using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class otpgate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profile",
                table: "Profile");

            migrationBuilder.RenameTable(
                name: "Profile",
                newName: "Profiles");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_UserId",
                table: "Profiles",
                newName: "IX_Profiles_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_PhoneNumber",
                table: "Profiles",
                newName: "IX_Profiles_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Profile_EmailAddress",
                table: "Profiles",
                newName: "IX_Profiles_EmailAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OtpHistories",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RetrievalCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Reference = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsEmail = table.Column<bool>(type: "bit", maxLength: 5, nullable: false),
                    InitiationDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    AttemptCount = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Purpose = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DateValidated = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtpHistories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OtpHistories_IsEmail",
                table: "OtpHistories",
                column: "IsEmail");

            migrationBuilder.CreateIndex(
                name: "IX_OtpHistories_Reference",
                table: "OtpHistories",
                column: "Reference");

            migrationBuilder.CreateIndex(
                name: "IX_OtpHistories_RetrievalCode",
                table: "OtpHistories",
                column: "RetrievalCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OtpHistories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Profiles",
                table: "Profiles");

            migrationBuilder.RenameTable(
                name: "Profiles",
                newName: "Profile");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_UserId",
                table: "Profile",
                newName: "IX_Profile_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_PhoneNumber",
                table: "Profile",
                newName: "IX_Profile_PhoneNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Profiles_EmailAddress",
                table: "Profile",
                newName: "IX_Profile_EmailAddress");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profile",
                table: "Profile",
                column: "Id");
        }
    }
}
