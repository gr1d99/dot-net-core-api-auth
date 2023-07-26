using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Models;

[Table("roles")]
public class Role
{
    public long Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public List<User> Users { get; } = new();
    public List<UserRole> UserRoles { get; } = new();
}
