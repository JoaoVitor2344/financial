using financial.DTOs;

namespace financial.Services;

public interface IAuthService
{
    Task<bool> RegisterAsync(RegisterUserDto model);
    Task<string?> LoginAsync(LoginUserDto model);
}