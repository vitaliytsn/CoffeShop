﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoffeShop.Migrations
{
    public partial class ComponentItemDelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "ComponentDelivery",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Active = table.Column<bool>(nullable: false),
                    DeliveryTime = table.Column<DateTime>(nullable: false),
                    CoffeShopId = table.Column<int>(nullable: true),
                    ComponentDeliveredId = table.Column<int>(nullable: true),
                    ItemDeliveredId = table.Column<int>(nullable: true),
                    UnitsDelivered = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentDelivery", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComponentDelivery_CoffeShops_CoffeShopId",
                        column: x => x.CoffeShopId,
                        principalTable: "CoffeShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComponentDelivery_Components_ComponentDeliveredId",
                        column: x => x.ComponentDeliveredId,
                        principalTable: "Components",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ComponentDelivery_Items_ItemDeliveredId",
                        column: x => x.ItemDeliveredId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

           

            migrationBuilder.CreateIndex(
                name: "IX_ComponentDelivery_CoffeShopId",
                table: "ComponentDelivery",
                column: "CoffeShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentDelivery_ComponentDeliveredId",
                table: "ComponentDelivery",
                column: "ComponentDeliveredId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentDelivery_ItemDeliveredId",
                table: "ComponentDelivery",
                column: "ItemDeliveredId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComponentDelivery");

           
        }
    }
}
