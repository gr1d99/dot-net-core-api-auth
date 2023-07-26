using System.ComponentModel.DataAnnotations.Schema;

namespace auth.Models;

[Table("users_roles")]
public class UserRole
{
    public long UserId { get; set; }
    public long RoleId { get; set; }
    public User User { get; set; } = null!;
    public Role Role { get; set; } = null!;
}
