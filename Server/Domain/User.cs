using Server.Domain.Common;

namespace Server.Domain;

public class User
{
    public UserId Id { get; init; } = UserId.From(Guid.NewGuid());

    public FirstName FirstName { get; init; } = default!;

    public LastName LastName { get; init; } = default!;

    public EmailAddress EmailAddress { get; init; } = default!;

    public DateOfBirth DateOfBirth { get; init; } = default!;
}