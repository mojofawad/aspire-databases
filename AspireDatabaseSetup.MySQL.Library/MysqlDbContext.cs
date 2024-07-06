using Microsoft.EntityFrameworkCore;

namespace AspireDatabaseSetup.MySQL.Library;

public class MysqlDbContext(DbContextOptions<MysqlDbContext> options) : DbContext(options)
{
    
}