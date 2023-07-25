using auth.Data;
using auth.Dto;
using auth.Models;

namespace auth.Services.Registration;

public class RegistrationService : IRegistrationService
{
    private readonly AuthDataContext _context;

    public RegistrationService(AuthDataContext context)
    {
        _context = context;
    }

    public async Task<UserModel> Create(CreateRegistrationDto data)
    {
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(data.Password);
        var user = new UserModel()
        {
            Email = data.Email,
            PasswordHash = passwordHash
        };

        _context.Users.Add(user);

        await _context.SaveChangesAsync();

        return user;
    }
}