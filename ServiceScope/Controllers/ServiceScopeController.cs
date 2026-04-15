using Microsoft.AspNetCore.Mvc;
using ServiceScope.Services;

namespace ServiceScope.Controllers;

[ApiController]
[Route("api/service-scope")]
public class ServiceScopeController(IServiceProvider serviceProvider) : ControllerBase
{
    public IActionResult Index([FromQuery(Name = "name")] string? name = null)
    {
        var service = serviceProvider.GetRequiredService<LifeTimeService>();

        var service2 = serviceProvider.GetRequiredService<SingletonLifeTimeService>();

        if (!string.IsNullOrEmpty(name))
        {
            service.Name = name;
            service2.Name = name;
        }


        var html = $"""
            <html>  
            <head><meta charset="UTF-8"></head>
            <body>
            <div style = "font-family: Arial, sans-serif; max-width: 600px; margin: auto;">
              <h2>Service 1</h2>
              {service}
              <h2>Service 2 Singleton</h2>
              {service2}
              </div>
            </body>
            </html>
            """;
        return Content(html, "text/html");
    }
}
