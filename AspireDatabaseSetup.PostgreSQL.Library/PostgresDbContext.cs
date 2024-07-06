using Microsoft.EntityFrameworkCore;

namespace AspireDatabaseSetup.PostgreSQL.Library;

public class PostgresDbContext(DbContextOptions<PostgresDbContext> options) : DbContext(options)
{
    
}