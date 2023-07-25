using auth.Dto;
using auth.Models;

namespace auth.Services.Auth;

public class AuthService : IAuthService
{
    public AuthService()
    {
        
    }

    public async Task<AuthDto> Create(CreateAuthDto credentials)
    {
        return new AuthDto()
        {
            JwtToken = "1"
        };
    }
}
