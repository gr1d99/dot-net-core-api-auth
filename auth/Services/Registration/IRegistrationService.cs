using auth.Dto;
using auth.Models;

namespace auth.Services.Registration;

public interface IRegistrationService
{
    public Task<UserModel> Create(CreateRegistrationDto data);
}
