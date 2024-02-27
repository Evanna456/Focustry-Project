using focustry_api.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<UserMiddleware>();
builder.Services.AddControllers();
var app = builder.Build();

app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"), appBuilder =>
{
    appBuilder.UseMiddleware<UserMiddleware>();
});

app.MapControllers();
app.Run();