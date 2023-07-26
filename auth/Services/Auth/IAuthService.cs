using auth.Dto;
using auth.Models;

namespace auth.Services.Auth;

public interface IAuthService
{
    public Task<Models.User?> Create(CreateAuthDto credentials);
}
