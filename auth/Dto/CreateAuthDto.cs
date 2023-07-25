using System.ComponentModel.DataAnnotations;

namespace auth.Dto;

public class CreateAuthDto
{
    [Required] public string Email { get; set; }
    [Required] public string Password { get; set; }
}
