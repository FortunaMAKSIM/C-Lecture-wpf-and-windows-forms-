using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static laba7.Models.Data.Entities;


namespace laba7.Models.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

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
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, Login = "1", Password = "1", RoleId = 1 },
                new User() { Id = 2, Login = "2", Password = "2", RoleId = 2 }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "Admin" },
                new Role() { Id = 2, Name = "User" }
                );
        }
    }
}
