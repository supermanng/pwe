using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class productaccount_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InterestCalculation",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "PaymentFrequency",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "RecurringPayment",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "TargetDate",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "TargetInterest",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "TargetPrincipal",
                table: "ProfileAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "ProfileAccounts",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<bool>(
                name: "IsWallet",
                table: "ProfileAccounts",
                type: "bit",
                maxLength: 20,
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAccounts_IsWallet",
                table: "ProfileAccounts",
                column: "IsWallet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ProfileAccounts_IsWallet",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "IsWallet",
                table: "ProfileAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "AccountNumber",
                table: "ProfileAccounts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "InterestCalculation",
                table: "ProfileAccounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentFrequency",
                table: "ProfileAccounts",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "RecurringPayment",
                table: "ProfileAccounts",
                type: "float",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TargetDate",
                table: "ProfileAccounts",
                type: "datetime2",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetInterest",
                table: "ProfileAccounts",
                type: "float",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TargetPrincipal",
                table: "ProfileAccounts",
                type: "float",
                maxLength: 20,
                nullable: true);
        }
    }
}
