using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba4.Data.Entities;

namespace laba4.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Material> Materials { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Material>().HasData(
                
                    new Material { Id = 1, Title = "Железо" },
                    new Material { Id = 2, Title = "Золото" },
                    new Material { Id = 3, Title = "Алмазы" },
                    new Material { Id = 4, Title = "Незерит" }
                );

            modelBuilder.Entity<Product>().HasData(

                    new Product { Id = 1, Title = "Шлем", Price = 50, MaterialId = 1 },
                    new Product { Id = 2, Title = "Броник", Price = 80, MaterialId = 1 },
                    new Product { Id = 3, Title = "Шлем", Price = 50, MaterialId = 2 },
                    new Product { Id = 4, Title = "Броник", Price = 80, MaterialId = 2 },
                    new Product { Id = 5, Title = "Меч", Price = 100, MaterialId = 3 },
                    new Product { Id = 6, Title = "Сапожки", Price = 130, MaterialId = 3 },
                    new Product { Id = 7, Title = "Меч", Price = 100, MaterialId = 4 },
                    new Product { Id = 8, Title = "Сапожки", Price = 130, MaterialId = 4 }
                );
        }
    }
}
