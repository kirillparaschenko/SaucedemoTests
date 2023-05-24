using Core.Models;

namespace Core.Models;

public record User
{
    public string Username { get; init; } = string.Empty;
    public string Password { get; init; } = string.Empty;
}