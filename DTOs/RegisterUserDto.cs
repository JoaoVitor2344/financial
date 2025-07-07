using System.ComponentModel.DataAnnotations;

namespace financial.DTOs;

public class RegisterUserDto
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public required string Username { get; set; }
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [EmailAddress(ErrorMessage = "O campo {0} está em um formato inválido.")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(100, ErrorMessage = "A {0} deve ter no mínimo {2} e no máximo {1} caracteres.", MinimumLength = 6)]
    public required string Password { get; set; }
}