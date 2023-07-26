using System.ComponentModel.DataAnnotations;

namespace auth.Dto;

public class UserDto
{
    [Required] public long Id { get; set; }
    [Required] public string Email { get; set; } = String.Empty;
    public List<RoleDto> Roles { get; set; } = new List<RoleDto>();
}
