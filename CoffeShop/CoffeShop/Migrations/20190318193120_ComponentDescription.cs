using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class ComponentDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "ItemImages",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Components",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Components");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ItemImages",
                newName: "id");
        }
    }
}
