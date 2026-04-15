using Microsoft.EntityFrameworkCore;
using ServiceScope.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


builder.Services.AddTransient<LifeTimeService>();
builder.Services.AddSingleton<SingletonLifeTimeService>();



var app = builder.Build();



app.MapControllers();

app.Run();

public class MyMidleWare(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        await next(context);
    }
}
