namespace Server.Contracts.Data;

public class UserDto
{
    public string Id { get; init; } = default!;

    public string FirstName { get; init; } = default!;

    public string LastName { get; init; } = default!;

    public string EmailAddress { get; init; } = default!;

    public DateTime DateOfBirth { get; init; } = default!;
}
