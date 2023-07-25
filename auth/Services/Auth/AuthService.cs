using auth.Data;
using auth.Dto;
using auth.Models;

namespace auth.Services.Auth;

public class AuthService : IAuthService
{
    private readonly AuthDataContext _context;
    public AuthService(AuthDataContext context)
    {
        _context = context;
    }

    public async Task<AuthDto> Create(CreateAuthDto credentials)
    {
        return new AuthDto()
        {
            JwtToken = "1"
        };
    }
}
