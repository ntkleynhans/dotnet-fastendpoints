using Dapper;

namespace Server.Database;

public class DatabaseInitializer
{
    private readonly IDbConnectionFactory _connectionFactory;

    public DatabaseInitializer(IDbConnectionFactory connectionFactory)
    {
        _connectionFactory = connectionFactory;
    }

    public async Task InitializeAsync()
    {
        using var connection = await _connectionFactory.CreateConnectionAsync();
        await connection.ExecuteAsync(@"
        CREATE TABLE IF NOT EXISTS Users (
        Id CHAR(36) PRIMARY KEY, 
        FirstName TEXT NOT NULL,
        LastName TEXT NOT NULL,
        EmailAddress TEXT NOT NULL,
        DateOfBirth TEXT NOT NULL)
        ");
    }
}
