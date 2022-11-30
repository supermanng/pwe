using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class transmig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "amount_settled",
                table: "TransactionLogs",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TokenId",
                table: "CustomerCard",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "amount_settled",
                table: "TransactionLogs");

            migrationBuilder.DropColumn(
                name: "TokenId",
                table: "CustomerCard");
        }
    }
}
