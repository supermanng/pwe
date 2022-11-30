using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class update_transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionLogs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Transaction_Ref = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Flw_Ref = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Device_Fingerprint = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<double>(type: "float", maxLength: 100, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Charged_Amount = table.Column<double>(type: "float", maxLength: 30, nullable: true),
                    App_fee = table.Column<double>(type: "float", maxLength: 100, nullable: true),
                    Merchant_Fee = table.Column<double>(type: "float", nullable: true),
                    Processor_Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Auth_Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IP = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Narration = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Payment_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TransStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Account_Id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionLogs_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_Account_Id",
                table: "TransactionLogs",
                column: "Account_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_ProfileId",
                table: "TransactionLogs",
                column: "ProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionLogs_Transaction_Ref",
                table: "TransactionLogs",
                column: "Transaction_Ref");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionLogs");
        }
    }
}
