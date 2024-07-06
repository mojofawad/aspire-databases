var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var mongoDb = builder.AddMongoDB("mongo").AddDatabase("mongodb", "mongodb");
var sqlDb = builder.AddSqlServer("sql").AddDatabase("sqldb", "sqldb");
var postgresDb = builder.AddPostgres("postgres").AddDatabase("postgresdb", "postgresdb");
var mysqlDb = builder.AddMySql("mysql").AddDatabase("mysqldb", "mysqldb");

var apiService = builder.AddProject<Projects.AspireDatabaseSetup_ApiService>("apiservice")
    .WithReference(mongoDb)
    .WithReference(sqlDb)
    .WithReference(postgresDb)
    .WithReference(mysqlDb);

builder.AddProject<Projects.AspireDatabaseSetup_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WithReference(apiService);

builder.Build().Run();