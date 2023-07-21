using auth.Dto;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController
{
    private ILogger<AuthController> _iLogger;

    public AuthController(ILogger<AuthController> iLogger)
    {
        _iLogger = iLogger;
    }

    public async Task<ActionResult<UserDto>> Create([FromBody] CreateAuthDto data)
    {
        return Ok();
    }
}
