﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class OrderItemPrimary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "OrderItem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderItem");
        }
    }
}
