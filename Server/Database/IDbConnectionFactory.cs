using System.Data;
using Microsoft.Data.Sqlite;

namespace Server.Database;

public interface IDbConnectionFactory
{
    public Task<IDbConnection> CreateConnectionAsync();
}
