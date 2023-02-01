using Server.Contracts.Data;

namespace Server.Repositories;

public interface IUserRepository
{
    Task<UserDto?> GetAsync(Guid Id);

    Task<bool> CreateAsync(UserDto user);
}
