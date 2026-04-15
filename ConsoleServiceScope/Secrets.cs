using Microsoft.Extensions.Configuration;

namespace ConsoleServiceScope;

public static class Secrets
{
    private static readonly IConfiguration Config = new ConfigurationBuilder()
        .AddUserSecrets<Program>()
        .Build();

    public static string AzureConnectionString =>
        Config["AzureDbConnectionString"]
        ?? throw new InvalidOperationException("Secret 'AzureDbConnectionString' is not set.");

}

