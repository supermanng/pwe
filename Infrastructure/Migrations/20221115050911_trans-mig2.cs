using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class transmig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerCard",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    First_6digits = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Last_4digits = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Issuer = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Expiry = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerCard_Profiles_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "Profiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_Expiry",
                table: "CustomerCard",
                column: "Expiry");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_First_6digits",
                table: "CustomerCard",
                column: "First_6digits");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_Issuer",
                table: "CustomerCard",
                column: "Issuer");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_Last_4digits",
                table: "CustomerCard",
                column: "Last_4digits");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCard_ProfileId",
                table: "CustomerCard",
                column: "ProfileId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerCard");
        }
    }
}
