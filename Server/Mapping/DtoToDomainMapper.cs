using Server.Contracts.Data;
using Server.Domain;
using Server.Domain.Common;

namespace Server.Mapping;

public static class DtoToDomainMapper
{
    public static User ToUser(this UserDto userDto)
    {
        return new User
        {
            Id = UserId.From(Guid.Parse(userDto.Id)),
            EmailAddress = EmailAddress.From(userDto.EmailAddress),
            FirstName = FirstName.From(userDto.FirstName),
            LastName = LastName.From(userDto.LastName),
            DateOfBirth = DateOfBirth.From(DateOnly.FromDateTime(userDto.DateOfBirth))
        };
    }
}
