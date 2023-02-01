using Server.Contracts.Request;
using Server.Domain;
using Server.Domain.Common;

namespace Server.Mapping;

public static class ApiContractToDomainMapper
{
    public static User ToUser(this CreateUserRequest request)
    {
        return new User{
            Id = UserId.From(Guid.NewGuid()),
            FirstName = FirstName.From(request.FirstName),
            LastName = LastName.From(request.LastName),
            EmailAddress = EmailAddress.From(request.EmailAddress),
            DateOfBirth = DateOfBirth.From(DateOnly.FromDateTime(request.DateOfBirth))
        };
    }
}
