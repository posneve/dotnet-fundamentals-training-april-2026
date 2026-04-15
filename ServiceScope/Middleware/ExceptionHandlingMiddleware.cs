using System.Text.Json;

namespace ServiceScope.Middleware;

public class ExceptionHandlingMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";

            var body = JsonSerializer.Serialize(new { message = ex.Message });
            await context.Response.WriteAsync(body);
        }
    }
}
