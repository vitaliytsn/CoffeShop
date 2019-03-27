﻿// <auto-generated />
using System;
using CoffeShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoffeShop.Migrations
{
    [DbContext(typeof(CoffeShopContext))]
    [Migration("20190326172745_TempOrder")]
    partial class TempOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoffeShop.Models.CoffeShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CoffeShops");
                });

            modelBuilder.Entity("CoffeShop.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("CoffeShop.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description");

                    b.Property<int?>("GroupId");

                    b.Property<string>("Name");

                    b.Property<int?>("OrderId");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("OrderId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("CoffeShop.Models.ItemComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<double>("Amount");

                    b.Property<int?>("ComponentItemId");

                    b.Property<int?>("CurrentComponentId");

                    b.HasKey("Id");

                    b.HasIndex("ComponentItemId");

                    b.HasIndex("CurrentComponentId");

                    b.ToTable("ItemComponents");
                });

            modelBuilder.Entity("CoffeShop.Models.ItemGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("ItemGroups");
                });

            modelBuilder.Entity("CoffeShop.Models.ItemImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<byte[]>("image");

                    b.Property<int>("itemId");

                    b.HasKey("Id");

                    b.HasIndex("itemId");

                    b.ToTable("ItemImages");
                });

            modelBuilder.Entity("CoffeShop.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int?>("CreatorUserId");

                    b.Property<bool>("Temp");

                    b.HasKey("Id");

                    b.HasIndex("CreatorUserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CoffeShop.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("CoffeShop.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<int?>("UserRoleId");

                    b.Property<int?>("UserShopId");

                    b.Property<string>("password");

                    b.HasKey("Id");

                    b.HasIndex("UserRoleId");

                    b.HasIndex("UserShopId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CoffeShop.Models.Item", b =>
                {
                    b.HasOne("CoffeShop.Models.ItemGroup", "Group")
                        .WithMany("GroupItems")
                        .HasForeignKey("GroupId");

                    b.HasOne("CoffeShop.Models.Order")
                        .WithMany("OrderedItems")
                        .HasForeignKey("OrderId");
                });

            modelBuilder.Entity("CoffeShop.Models.ItemComponent", b =>
                {
                    b.HasOne("CoffeShop.Models.Item", "ComponentItem")
                        .WithMany("ItemComponents")
                        .HasForeignKey("ComponentItemId");

                    b.HasOne("CoffeShop.Models.Component", "CurrentComponent")
                        .WithMany()
                        .HasForeignKey("CurrentComponentId");
                });

            modelBuilder.Entity("CoffeShop.Models.ItemImage", b =>
                {
                    b.HasOne("CoffeShop.Models.Item")
                        .WithMany("Images")
                        .HasForeignKey("itemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoffeShop.Models.Order", b =>
                {
                    b.HasOne("CoffeShop.Models.User", "CreatorUser")
                        .WithMany()
                        .HasForeignKey("CreatorUserId");
                });

            modelBuilder.Entity("CoffeShop.Models.User", b =>
                {
                    b.HasOne("CoffeShop.Models.Role", "UserRole")
                        .WithMany()
                        .HasForeignKey("UserRoleId");

                    b.HasOne("CoffeShop.Models.CoffeShop", "UserShop")
                        .WithMany()
                        .HasForeignKey("UserShopId");
                });
#pragma warning restore 612, 618
        }
    }
}
