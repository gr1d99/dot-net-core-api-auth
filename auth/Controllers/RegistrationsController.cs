using auth.Dto;
using auth.Services.Registration;
using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistrationsController : ControllerBase
{
    private readonly IRegistrationService _service;
    private ILogger<RegistrationsController> _iLogger;

    public RegistrationsController(ILogger<RegistrationsController> iLogger, IRegistrationService service)
    {
        _iLogger = iLogger;
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Create([FromBody] CreateRegistrationDto data)
    {
        var user = await _service.Create(data);
        return Ok(new UserDto()
        {
            Id = user.Id,
            Email = user.Email
        });
    }
}
