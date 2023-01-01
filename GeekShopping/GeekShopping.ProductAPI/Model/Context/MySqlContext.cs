using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {
        }

        public MySqlContext(DbContextOptions<MySqlContext> options) :
            base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Name",
                Price = 50,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Name",
                Price = 100,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Name",
                Price = 150,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Name",
                Price = 200,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Name",
                Price = 250,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Name",
                Price = 300,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Name",
                Price = 350,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Name",
                Price = 400,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Name",
                Price = 450,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Name",
                Price = 500,
                Description = "Description",
                ImageUrl = "www.google.com",
                CategoryName = "Category"
            });
        }


    }
}
