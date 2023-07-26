using auth.Dto;
using auth.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private ILogger<UsersController> _logger;
    private readonly IUserService _service;
    public UsersController(ILogger<UsersController> logger, IUserService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> CreateUser([FromBody] CreateUserDto data)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDto>>> Users()
    {
        var users = await _service.Users();

        List<UserDto> userListDto = users.Select(u => new UserDto()
        {
            Id = u.Id,
            Email = u.Email,
            Roles = _service
                .UserRoles(u)
                .Select(r => new RoleDto() { Id = r.Id, Name = r.Name })
                .ToList()
        }).ToList();

        return userListDto;
    }
}
