using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class changesbvn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bvn",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BvnDate",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BvnVerificationDate",
                table: "Profiles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasConfirmedBvn",
                table: "Profiles",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bvn",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BvnDate",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "BvnVerificationDate",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "HasConfirmedBvn",
                table: "Profiles");
        }
    }
}
