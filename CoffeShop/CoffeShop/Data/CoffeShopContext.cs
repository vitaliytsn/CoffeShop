using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeShop.Models;
using Microsoft.EntityFrameworkCore;
using CoffeShop.Models.ViewModels;

namespace CoffeShop.Data
{
    public class CoffeShopContext: DbContext
    {
        public CoffeShopContext()
        {
        }

        public CoffeShopContext(DbContextOptions<CoffeShopContext> options)
            : base(options)
        {
        }
        public Microsoft.EntityFrameworkCore.DbSet<Item> Items { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemImage> ItemImages { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Component> Components { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemComponent> ItemComponents { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemGroup> ItemGroups { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Order> Orders { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Role> Roles { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<User> Users { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Models.CoffeShop> CoffeShops { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ComponentDelivery> ComponentDelivery { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Item>().HasOne(s => s.Group).WithMany(s=>s.GroupItems);

            builder.Entity<OrderItem>()
                .HasKey(bc => new { bc.ItemId, bc.OrderId });
            builder.Entity<OrderItem>()
                .HasOne(bc => bc.Item)
                .WithMany(b => b.OrderItems)
                .HasForeignKey(bc => bc.ItemId);
            builder.Entity<OrderItem>()
                .HasOne(bc => bc.Order)
                .WithMany(c => c.OrderItems)
                .HasForeignKey(bc => bc.OrderId);
        }

    }
}
