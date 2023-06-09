﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using top_shop_models;

namespace top_shop_dbconnector
{
    public class TopShopContext : DbContext
    {
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemWarehouse> ItemWarehouses { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer((string?)JObject.Parse(File.ReadAllText("settings.json"))?["connectionString"]?.ToString() ?? throw new Exception("Settings are lost!"));
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entity.ClrType)
                            .Property("Id")
                            .HasDefaultValueSql("NEWSEQUENTIALID()");

                modelBuilder.Entity<Client>().Property(nameof(Client.Discount)).HasDefaultValue(0);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
