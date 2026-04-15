using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;

namespace TestProject1;

public class TestFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        // Runs BEFORE app startup — app can override you
        // Useful for adding services the app doesn't register
        builder.ConfigureServices(services =>
        {
            Console.WriteLine("ConfigureServices started");
        });

        // Runs AFTER app startup — you override the app
        // Ideal for swapping real services with fakes/mocks
        builder.ConfigureTestServices(services =>
        {
            Console.WriteLine("ConfigureTestServices started");
        });
    }
}

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void Test1()
    {
    }
}