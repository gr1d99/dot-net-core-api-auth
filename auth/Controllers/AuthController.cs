using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using auth.Dto;
using auth.Models;
using auth.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace auth.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IAuthService _service;
    private ILogger<AuthController> _iLogger;

    public AuthController(ILogger<AuthController> iLogger, IAuthService service, IConfiguration configuration)
    {
        _iLogger = iLogger;
        _service = service;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<ActionResult<UserDto>> Create([FromBody] CreateAuthDto data)
    {
        var user = await _service.Create(data);

        if (user is null)
        {
            return Unauthorized(new { Message = "Incorrect email or password" });
        }

        return Ok(new AuthDto()
        {
            JwtToken = CreateUserToken(user)
        });
    }

    private string CreateUserToken(UserModel user)
    {
        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.Email, user.Email)
        };

        var value = _configuration.GetValue<string>("JWT_TOKEN_KEY");
        var bytes = Encoding.UTF8.GetBytes(value!);
        var key = new SymmetricSecurityKey(bytes);
        var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: signingCredentials
        );

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
}
