
using Microsoft.EntityFrameworkCore;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<MyClass> MyClasses { get; set; } = null!;
}

public class MyClass
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; }
}
