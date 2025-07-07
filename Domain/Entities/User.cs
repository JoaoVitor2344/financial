namespace financial.Domain.Entities;

public class User
{
    public required Guid Id { get; set; }
    public required string Email { get; set; }
    public required string Username { get; set; }
    public required string PasswordHash { get; set; }
    public required DateTime CreatedAt { get; set; }
}