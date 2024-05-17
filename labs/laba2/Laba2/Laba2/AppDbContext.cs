using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WinFormsApp.Database.Entities;

namespace WinFormsApp.Database;

internal class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
        //Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Login = "admin",
            Password = "admin"
        });

        modelBuilder.Entity<User>()
            .Property(x => x.Password)
            .HasConversion(new ValueConverter<UserPassword, string>(
                val => val,
                val => val
                ));
    }
}