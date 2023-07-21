using System.ComponentModel.DataAnnotations;

namespace auth.Dto;

public class CreateUserDto
{
    [Required] public string Email { get; set; } = String.Empty;
    [Required] public string Password { get; set; } = String.Empty;
}
