using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class ChangesForRaports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "ItemCost",
                table: "OrderItem",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ItemPrice",
                table: "OrderItem",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "AlreadyUsed",
                table: "ComponentDelivery",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "LeftOver",
                table: "ComponentDelivery",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemCost",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "AlreadyUsed",
                table: "ComponentDelivery");

            migrationBuilder.DropColumn(
                name: "LeftOver",
                table: "ComponentDelivery");
        }
    }
}
