using Server.Contracts.Data;
using Server.Database;
using Dapper;

namespace Server.Repositories;

public class UserRepository : IUserRepository
{
    private readonly IDbConnectionFactory _connectionFactory;

    public UserRepository(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task<UserDto?> GetAsync(Guid Id) 
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        return await connection.QuerySingleOrDefaultAsync<UserDto>(
            "SELECT * FROM Users WHERE Id = @Id LIMIT 1", new { Id = Id.ToString() });
    }

    public async Task<bool> CreateAsync(UserDto user)
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        var result = await connection.ExecuteAsync(
            @"INSERT INTO USers (Id, FirstName, LastName, EmailAddress, DateOfBirth) 
            VALUES (@Id, @FirstName, @LastName, @EmailAddress, @DateOfBirth)",
            user);
        return result > 0;
    }
}
