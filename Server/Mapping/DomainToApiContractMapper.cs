using Server.Domain;
using Server.Contracts.Response;

namespace Server.Mapping;

public static class DomainToApiContractMapper
{
    public static UserResponse ToUserResponse(this User user)
    {
        return new UserResponse
        {
            Id = user.Id.Value,
            EmailAddress = user.EmailAddress.Value,
            FirstName = user.FirstName.Value,
            LastName = user.LastName.Value,
            DateOfBirth = user.DateOfBirth.Value.ToDateTime(TimeOnly.MinValue)
        };
    }
}
