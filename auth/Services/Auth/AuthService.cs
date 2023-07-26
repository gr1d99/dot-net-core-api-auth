using auth.Data;
using auth.Dto;
using auth.Models;
using Microsoft.EntityFrameworkCore;

namespace auth.Services.Auth;

public class AuthService : IAuthService
{
    private readonly AuthDataContext _context;
    public AuthService(AuthDataContext context)
    {
        _context = context;
    }

    public async Task<Models.User?> Create(CreateAuthDto credentials)
    {
        var user = await _context.Users.Where(u => u.Email == credentials.Email).FirstOrDefaultAsync();

        if (user is null)
        {
            return null;
        }

        var isCorrectPassword = BCrypt.Net.BCrypt.Verify(credentials.Password, user.PasswordHash);

        if (isCorrectPassword is false)
        {
            return null;
        }

        return user;
    }
}
