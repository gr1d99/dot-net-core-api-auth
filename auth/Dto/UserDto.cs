namespace auth.Dto;

public class UserDto
{
    public long Id { get; set; }
    public string Email { get; set; } = String.Empty;
    public string Password { get; set; } = String.Empty;
}
