
namespace Server.Contracts.Request;

public class CreateUserRequest
{
    public string FirstName { get; init; } = default!;
    public string LastName { get; init; } = default!;
    public string EmailAddress { get; init; } = default!;
    public DateTime DateOfBirth { get; init; }
}
