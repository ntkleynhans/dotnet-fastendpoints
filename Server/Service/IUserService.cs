using Server.Domain;

namespace Server.Service;

public interface IUserService
{
    Task<User?> GetAsync(Guid Id);
    Task<bool> CreateAsync(User user);
}
