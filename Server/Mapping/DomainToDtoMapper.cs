using Server.Contracts.Data;
using Server.Domain;


namespace Server.Mapping;

public static class DomainToDtoMapper
{
    public static UserDto ToUserDto(this User user)
    {
        return new UserDto 
        {
            Id = user.Id.Value.ToString(),
            FirstName = user.FirstName.Value,
            LastName = user.LastName.Value,
            EmailAddress = user.EmailAddress.Value,
            DateOfBirth = user.DateOfBirth.Value.ToDateTime(TimeOnly.MinValue)
        };
    }
}
