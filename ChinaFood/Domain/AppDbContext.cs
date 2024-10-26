using ChinaFood.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace ChinaFood.Domain;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        //Setting Room, Room facility binding table PK.
        builder.Entity<OrderItem>()
            .HasKey(cs => new { cs.OrderId, cs.DishId });

        //Adding new user role to database.
        builder.Entity<IdentityRole>().HasData(new IdentityRole
        {
            Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
            Name = "admin",
            NormalizedName = "ADMIN"
        });

        //Adding new user to database.
        builder.Entity<User>().HasData(new User
        {
            Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Email = "my@email.com",
            NormalizedEmail = "MY@EMAIL.COM",
            EmailConfirmed = true,
            PasswordHash = new PasswordHasher<User>().HashPassword(null, "superpassword"),
            SecurityStamp = string.Empty
        });

        //Adding new user-role link to database.
        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
            UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
        });
    }
}
