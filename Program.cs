using ServiceScope.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddTransient<LifeTimeService>();

var app = builder.Build();

app.MapControllers();

app.Run();
