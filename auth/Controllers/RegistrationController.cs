using Microsoft.AspNetCore.Mvc;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistrationController
{
    private ILogger<RegistrationController> _iLogger;

    public RegistrationController(ILogger<RegistrationController> iLogger)
    {
        _iLogger = iLogger;
    }
}
