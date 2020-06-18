using HomeSales.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeSales.Data
{
    public class HomeSalesDbContext : IdentityDbContext<IdentityUser>
    {
        public HomeSalesDbContext(DbContextOptions<HomeSalesDbContext> options) :
            base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Odzież" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Sprzęty domowe" });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Bluza Sons of Anarchy",
                Price = 50M,
                Description = "Czarna bluza z serialu Sons of Anarchy, rozmiar L.",
                CategoryId = 1,
                ImageUrl = "\\Images\\bluzatyl.jpg",
                ImageThumbnailUrl = "\\Images\\bluzatyl.jpg",
                //ImageThumbnailUrl = "\\Images\\thumbnails\\bluzatyl.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Suszarka",
                Price = 25M,
                Description = "Suszarka do włosów",
                CategoryId = 2,
                ImageUrl = "\\Images\\suszarka.jpg",
                ImageThumbnailUrl = "\\Images\\suszarka.jpg",
                //ImageThumbnailUrl = "\\Images\\thumbnails\\suszarka.jpg",
                IsInStock = true,
                IsOnSale = true
            });

        }
    }
}
