using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class transmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecurrent",
                table: "TransactionLogs",
                type: "bit",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransSessionId",
                table: "TransactionLogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionCompletionDate",
                table: "TransactionLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "TransactionHasBeenPosted",
                table: "TransactionLogs",
                type: "bit",
                maxLength: 10,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "TransactionPostingDate",
                table: "TransactionLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionRefId",
                table: "TransactionLogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TransactionType",
                table: "TransactionLogs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_IsRecurrent",
                table: "TransactionLogs",
                column: "IsRecurrent");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransactionHasBeenPosted",
                table: "TransactionLogs",
                column: "TransactionHasBeenPosted");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransactionRefId",
                table: "TransactionLogs",
                column: "TransactionRefId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransactionType",
                table: "TransactionLogs",
                column: "TransactionType");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_TransSessionId",
                table: "TransactionLogs",
                column: "TransSessionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_IsRecurrent",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransactionHasBeenPosted",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransactionRefId",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransactionType",
                table: "TransactionLogs");

            migrationBuilder.DropIndex(
                name: "IX_TransactionLogs_TransSessionId",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "IsRecurrent",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransSessionId",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransactionCompletionDate",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransactionHasBeenPosted",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransactionPostingDate",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransactionRefId",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TransactionType",
                table: "TransactionLogs");
        }
    }
}
