using Server.Contracts.Data;
using Server.Domain;
using Server.Mapping;
using Server.Repositories;

namespace Server.Service;

public class UserService : IUserService
{
    private readonly IUserRepository _repo;
    public UserService(IUserRepository repo)
    {
        _repo = repo;
    }
    public async Task<User?> GetAsync(Guid Id)
    {
        var userDto = await _repo.GetAsync(Id);
        return userDto?.ToUser();
    }

    public async Task<bool> CreateAsync(User user)
    {
        var existing = await _repo.GetAsync(user.Id.Value);
        if(existing is not null)
        {
            return false;
        }
        UserDto userDto = user.ToUserDto();
        return await _repo.CreateAsync(userDto);
    }
}
