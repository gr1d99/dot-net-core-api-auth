using auth.Data;
using auth.Models;
using Microsoft.EntityFrameworkCore;

namespace auth.Services.User;

public class UserService : IUserService
{
    private readonly AuthDataContext _context;

    public UserService(AuthDataContext context)
    {
        _context = context;
    }

    public async Task<List<Models.User>> Users()
    {
        return await _context.Users.Include(u => u.Roles).ToListAsync();
    }

    public List<Role> UserRoles(Models.User user)
    {
        return user.Roles.ToList();
    }
}
