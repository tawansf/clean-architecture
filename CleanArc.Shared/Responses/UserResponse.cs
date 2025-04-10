namespace CleanArc.Shared.Responses;

public sealed class UserResponse
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Email { get; init; }
}