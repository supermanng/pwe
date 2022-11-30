using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileAccounts_Products_ProductId",
                table: "ProfileAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ProfileAccounts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "PlanDetailId",
                table: "ProfileAccounts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerPlans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PlanDetailId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProfileAccountId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpectedAmount = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    ExpectedPrincipal = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    ExpectedInterest = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", maxLength: 20, nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", maxLength: 50, nullable: true),
                    InterestRate = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    Tax = table.Column<double>(type: "float", nullable: true),
                    Frequency = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    TenorCount = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    Termination = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AccruedInterest = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerPlans_ProfileAccounts_ProfileAccountId",
                        column: x => x.ProfileAccountId,
                        principalTable: "ProfileAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProductType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    GLCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChargesGLCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlanDetails",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PlanId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AllowsWithdrawal = table.Column<bool>(type: "bit", maxLength: 10, nullable: true),
                    IsLocked = table.Column<bool>(type: "bit", maxLength: 10, nullable: true),
                    MaxWithdrawal = table.Column<int>(type: "int", maxLength: 20, nullable: true),
                    InterestRate = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    Tax = table.Column<double>(type: "float", maxLength: 20, nullable: true),
                    MinTenor = table.Column<int>(type: "int", maxLength: 10, nullable: true),
                    InterestIsCalculated = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ChargesGLCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GLCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanDetails_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProfileAccounts_PlanDetailId",
                table: "ProfileAccounts",
                column: "PlanDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPlans_PlanDetailId",
                table: "CustomerPlans",
                column: "PlanDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPlans_ProfileAccountId",
                table: "CustomerPlans",
                column: "ProfileAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetails_ChargesGLCode",
                table: "PlanDetails",
                column: "ChargesGLCode");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetails_GLCode",
                table: "PlanDetails",
                column: "GLCode");

            migrationBuilder.CreateIndex(
                name: "IX_PlanDetails_PlanId",
                table: "PlanDetails",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_ChargesGLCode",
                table: "Plans",
                column: "ChargesGLCode");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_GLCode",
                table: "Plans",
                column: "GLCode");

            migrationBuilder.CreateIndex(
                name: "IX_Plans_ProductType",
                table: "Plans",
                column: "ProductType");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileAccounts_PlanDetails_PlanDetailId",
                table: "ProfileAccounts",
                column: "PlanDetailId",
                principalTable: "PlanDetails",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileAccounts_Products_ProductId",
                table: "ProfileAccounts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProfileAccounts_PlanDetails_PlanDetailId",
                table: "ProfileAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_ProfileAccounts_Products_ProductId",
                table: "ProfileAccounts");

            migrationBuilder.DropTable(
                name: "CustomerPlans");

            migrationBuilder.DropTable(
                name: "PlanDetails");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropIndex(
                name: "IX_ProfileAccounts_PlanDetailId",
                table: "ProfileAccounts");

            migrationBuilder.DropColumn(
                name: "PlanDetailId",
                table: "ProfileAccounts");

            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "ProfileAccounts",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ProfileAccounts_Products_ProductId",
                table: "ProfileAccounts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
