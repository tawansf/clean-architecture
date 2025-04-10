namespace CleanArc.Shared.Requests;

public record UserRequest
{
    string Name { get; init; }
    string Email { get; init; }
}