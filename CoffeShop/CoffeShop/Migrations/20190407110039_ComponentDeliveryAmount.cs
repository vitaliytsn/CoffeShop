using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class ComponentDeliveryAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "ComponentDelivery",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ComponentDelivery");
        }
    }
}
