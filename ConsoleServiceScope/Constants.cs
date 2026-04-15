using Microsoft.Extensions.Configuration;

namespace ConsoleServiceScope;

public static class Constants
{
    public static string SqlLiteConnectionString =  "Data Source=:memory:";


}

public static class Secrets
{
    private static readonly IConfiguration Config = new ConfigurationBuilder()
        .AddUserSecrets<Program>()
        .Build();

    public static string AzureConnectionString =>
        Config["AzureDbConnectionString"]
        ?? throw new InvalidOperationException("Secret 'AzureDbConnectionString' is not set.");

}

