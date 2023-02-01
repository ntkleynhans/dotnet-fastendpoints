namespace Server.Contracts.Response;

public class UserResponse
{
    public Guid Id { get; init; }

    public string FirstName { get; init; } = default!;

    public string LastName { get; init; } = default!;

    public string EmailAddress { get; init; } = default!;

    public DateTime DateOfBirth { get; init; }
}
