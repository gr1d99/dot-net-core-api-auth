using auth.Dto;

namespace auth.Services.Auth;

public interface IAuthService
{
    public Task<AuthDto> Create(CreateAuthDto credentials);
}