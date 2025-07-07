using financial.DTOs;
using financial.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto model)
    {
        var result = await _authService.RegisterAsync(model);
        if (!result)
        {
            return BadRequest(new { Message = "Usuário já existe ou dados inválidos." });
        }
        return Ok(new { Message = "Usuário criado com sucesso!" });
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginUserDto model)
    {
        var token = await _authService.LoginAsync(model);
        if (token == null)
        {
            return Unauthorized(new { Message = "Credenciais inválidas." });
        }
        return Ok(new { token });
    }
}