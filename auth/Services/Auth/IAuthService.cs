using auth.Dto;
using auth.Models;

namespace auth.Services.Auth;

public interface IAuthService
{
    public Task<UserModel?> Create(CreateAuthDto credentials);
}
