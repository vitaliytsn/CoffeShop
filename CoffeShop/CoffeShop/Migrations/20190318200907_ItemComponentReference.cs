using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class ItemComponentReference : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemComponents_Items_ItemId",
                table: "ItemComponents");

            migrationBuilder.RenameColumn(
                name: "amount",
                table: "ItemComponents",
                newName: "Amount");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemComponents",
                newName: "ComponentItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemComponents_ItemId",
                table: "ItemComponents",
                newName: "IX_ItemComponents_ComponentItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemComponents_Items_ComponentItemId",
                table: "ItemComponents",
                column: "ComponentItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemComponents_Items_ComponentItemId",
                table: "ItemComponents");

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "ItemComponents",
                newName: "amount");

            migrationBuilder.RenameColumn(
                name: "ComponentItemId",
                table: "ItemComponents",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemComponents_ComponentItemId",
                table: "ItemComponents",
                newName: "IX_ItemComponents_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemComponents_Items_ItemId",
                table: "ItemComponents",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
