using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Models;

[Table("users")]
public class User
{
    public long Id { get; set; }
    public string Email { get; set; } = String.Empty;
    public string PasswordHash { get; set; } = String.Empty;
    public List<Role> Roles { get; } = new();
    public List<UserRole> UserRoles { get; } = new();
}
