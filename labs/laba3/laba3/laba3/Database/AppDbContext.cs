using laba3.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3.Database
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Material> Materials { get; set; }


        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }
        private void SeedData(ModelBuilder modelBuilder)
        {
            List<Material> materials =
                [
                    new() { Id = 1, Name = "Beads" },
                    new() { Id = 2, Name = "Amulet" },
                    new() { Id = 3, Name = "Beads" },
                    new() { Id = 4, Name = "Amulet" }
                ];

            List<Product> products =
                [
                    new() { Id = 1, Name = "Mag-Assasin", Price = 100, MaterialId = 1 },
                    new() { Id = 2, Name = "Buba", Price = 100, MaterialId = 2 },
                    new() { Id = 3, Name = "Frog", Price = 100, MaterialId = 3 },
                    new() { Id = 4, Name = "Nitro", Price = 100, MaterialId = 4 },
                    new() { Id = 5, Name = "Jam", Price = 100, MaterialId = 4 },
                    new() { Id = 6, Name = "Orange", Price = 100, MaterialId = 3 },
                    new() { Id = 7, Name = "GG", Price = 100, MaterialId = 2 },
                    new() { Id = 8, Name = "Anti-phantom", Price = 100, MaterialId = 1 }
                ];

            modelBuilder.Entity<Material>()
                .HasData(materials);
            modelBuilder.Entity<Product>()
                .HasData(products);
        }
    }
}
 