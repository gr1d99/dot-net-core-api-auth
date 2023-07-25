using auth.Dto;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private ILogger<AuthController> _iLogger;

    public AuthController(ILogger<AuthController> iLogger)
    {
        _iLogger = iLogger;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Create([FromBody] CreateAuthDto data)
    {
        var res = new UserDto()
        {
            Email = "",
            Id = 1
        };

        return Ok(res);
    }
}
