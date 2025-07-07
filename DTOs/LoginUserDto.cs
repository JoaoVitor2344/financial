using System.ComponentModel.DataAnnotations;

namespace financial.DTOs;

public class LoginUserDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo {0} está em um formato inválido.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required string Password { get; set; }
}