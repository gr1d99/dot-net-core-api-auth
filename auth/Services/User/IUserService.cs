using auth.Models;

namespace auth.Services.User;

public interface IUserService
{
    public Task<List<Models.User>> Users();
    public List<Role> UserRoles(Models.User user);
}
