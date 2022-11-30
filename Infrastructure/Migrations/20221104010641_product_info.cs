using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class product_info : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GLCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MinimumTenior = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    InterestCalculation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MinimumAmount = table.Column<double>(type: "float", maxLength: 5, nullable: true),
                    WithdrawalLimit = table.Column<int>(type: "int", maxLength: 5, nullable: true),
                    InterestRate = table.Column<double>(type: "float", maxLength: 5, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountToDebit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountToCredit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProfileAccounts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RecurringPayment = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    TargetPrincipal = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    TargetInterest = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    InterestCalculation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TargetDate = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    PaymentFrequency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProfileAccounts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProfileAccounts_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_AccountToCredit",
                table: "ProductDetails",
                column: "AccountToCredit");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_AccountToDebit",
                table: "ProductDetails",
                column: "AccountToDebit");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductId",
                table: "ProductDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_GLCode",
                table: "Products",
                column: "GLCode");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Name",
                table: "Products",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAccounts_AccountNumber",
                table: "ProfileAccounts",
                column: "AccountNumber");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAccounts_ProductId",
                table: "ProfileAccounts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAccounts_ProfileId",
                table: "ProfileAccounts",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProfileAccounts");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
