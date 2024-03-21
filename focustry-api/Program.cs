using focustry_api.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<UserMiddleware>();
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Allow",
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
var app = builder.Build();
app.UseCors("Allow");
app.UseWhen(context => context.Request.Path.StartsWithSegments("/api"), appBuilder =>
{
    appBuilder.UseMiddleware<UserMiddleware>();
});
app.MapControllers();
app.Run();