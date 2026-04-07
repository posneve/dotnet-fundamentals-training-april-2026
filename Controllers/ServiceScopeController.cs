using Microsoft.AspNetCore.Mvc;
using ServiceScope.Services;

namespace ServiceScope.Controllers;

[ApiController]
public class ServiceScopeController(IServiceProvider sp) : ControllerBase
{
    // ── Welcome ──────────────────────────────────────────────────────────────
    [HttpGet("/")]
    public IActionResult Index([FromQuery(Name = "name")] string? name = null)
    {
        var service = sp.GetRequiredService<LifeTimeService>();


        var service2 = sp.GetRequiredService<LifeTimeService>();

        if (!string.IsNullOrEmpty(name))
        {
            service.Name = name;
            service2.Name = name;
        }


        var html = $"""
            <html>
            <body>
              <h1>Service 1</h1>
              {service}
              <h1>Service 2</h1>
              {service2}
            </body>
            </html>
            """;
        return Content(html, "text/html");
    }
}
