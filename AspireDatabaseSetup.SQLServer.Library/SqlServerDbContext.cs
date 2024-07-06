using Microsoft.EntityFrameworkCore;

namespace AspireDatabaseSetup.SQLServer.Library;

public class SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : DbContext(options)
{
    
}