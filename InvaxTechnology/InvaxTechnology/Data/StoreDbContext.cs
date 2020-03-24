﻿using InvaxTechnology.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvaxTechnology.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding Data
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    Sku = "CAC001",
                    Name = "Atlantic",
                    Price = 12,
                    Description = "A combination of multiple small cactuses",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC001",
                    IsFeatured = true
                },
                new Product
                {
                    ID = 2,
                    Sku = "CAC002",
                    Name = "Rosette",
                    Price = 9,
                    Description = "A hot pink little cactus to bright up your room",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC002",
                    IsFeatured = true
                },
                new Product
                {
                    ID = 3,
                    Sku = "CAC003",
                    Name = "Pastel",
                    Price = 7,
                    Description = "This cactus with elegant-looking glass is perfect for your desk",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC003",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 4,
                    Sku = "CAC004",
                    Name = "Coral",
                    Price = 10,
                    Description = "This cute little coral will definitely lighten up your mood",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC004",
                    IsFeatured = true
                },
                new Product
                {
                    ID = 5,
                    Sku = "CAC005",
                    Name = "Parakeet",
                    Price = 18,
                    Description = "The unique looking little parakeet is one of the tiny plants that you must have",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC005",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 6,
                    Sku = "CAC006",
                    Name = "Crimson",
                    Price = 17,
                    Description = "This spiky and layered looking cactus is defenitely a rare found",
                    Image = "https://tinyplants.blob.core.windows.net/products/CAC006",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 7,
                    Sku = "FLW001",
                    Name = "Arctic",
                    Price = 24,
                    Description = "A blue orchid is one of the best indoor plants that you can have",
                    Image = "https://tinyplants.blob.core.windows.net/products/FLW001",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 8,
                    Sku = "FLW002",
                    Name = "Violet Kokedama",
                    Price = 29,
                    Description = "This ornamental plant comes with violet flowers and kokedama that adds more style to your plant",
                    Image = "https://tinyplants.blob.core.windows.net/products/FLW002",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 9,
                    Sku = "PLN001",
                    Name = "Bamboo",
                    Price = 26,
                    Description = "Bamboo is easy to take care of and it grows fast",
                    Image = "https://tinyplants.blob.core.windows.net/products/PLN001",
                    IsFeatured = false
                },
                new Product
                {
                    ID = 10,
                    Sku = "PLN002",
                    Name = "Hyacinth",
                    Price = 22,
                    Description = "This plant can live in water and it makes a great indoor plant",
                    Image = "https://tinyplants.blob.core.windows.net/products/PLN002",
                    IsFeatured = false
                }
                );
        }

        public DbSet<Product> Product { get; set; }
    }
}
