using auth.Dto;
using auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistrationsController : ControllerBase
{
    private static UserModel user = new UserModel();
    private ILogger<RegistrationsController> _iLogger;

    public RegistrationsController(ILogger<RegistrationsController> iLogger)
    {
        _iLogger = iLogger;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Create([FromBody] CreateRegistrationDto data)
    {
        var passwordHash = BCrypt.Net.BCrypt.HashPassword(data.Password);

        user.Email = data.Email;
        user.PasswordHash = passwordHash;

        var response = new UserDto()
        {
            Id = user.Id,
            Email = user.Email,
        };

        return Ok(response);
    }
}
