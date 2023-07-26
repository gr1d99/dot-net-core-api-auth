using auth.Models;
using Microsoft.EntityFrameworkCore;

namespace auth.Data;

public class AuthDataContext : DbContext
{
    public AuthDataContext(DbContextOptions<AuthDataContext> options) : base(options)
    {}

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<UserRole> UsersRoles { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().ToTable("users").HasKey(u => u.Id);
        modelBuilder.Entity<Role>().ToTable("roles");
        modelBuilder.Entity<UserRole>().ToTable("users_roles");
        modelBuilder.Entity<User>()
            .HasMany<Role>(u => u.Roles)
            .WithMany(r => r.Users)
            .UsingEntity<UserRole>();
        modelBuilder.Entity<Role>()
            .HasMany<User>(r => r.Users)
            .WithMany(u => u.Roles)
            .UsingEntity<UserRole>();
    }
}
