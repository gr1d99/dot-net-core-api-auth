using System.ComponentModel.DataAnnotations;

namespace auth.Dto;

public class CreateRegistrationDto
{
    [Required(ErrorMessage = "Email is required!")] public string Email { get; set; } = String.Empty;
    [Required(ErrorMessage = "Password id required!")] public string Password { get; set; } = String.Empty;
    [Compare("Password", ErrorMessage = "Passwords must match")]
    [Required(ErrorMessage = "Confirm Password is required!")] public string ConfirmPassword { get; set; } = String.Empty;
}
