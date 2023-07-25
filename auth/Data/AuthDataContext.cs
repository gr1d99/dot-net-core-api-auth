using auth.Models;
using Microsoft.EntityFrameworkCore;

namespace auth.Data;

public class AuthDataContext : DbContext
{
    public AuthDataContext(DbContextOptions<AuthDataContext> options) : base(options)
    {}

    public DbSet<UserModel> Users { get; set; } = null!;
}
