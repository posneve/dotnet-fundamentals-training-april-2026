using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ConsoleServiceScope;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<MyClass> MyClasses { get; set; } = null!;
}

public class MyDbContextFactory : IDesignTimeDbContextFactory<MyDbContext>
{
    public MyDbContext CreateDbContext(string[] args)
    {
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseSqlite("DataSource=:memory:")
            .Options;
        return new MyDbContext(options);
    }
}

public static class DbContextHelper
{
    public static DbContextOptionsBuilder<MyDbContext> CreateBuilder()
    {
        var sqlLiteConnection = new SqliteConnection("DataSource=:memory:");
        sqlLiteConnection.Open();
        var options = new DbContextOptionsBuilder<MyDbContext>()
            .UseSqlite(connection: sqlLiteConnection);
        return options;
    }
}