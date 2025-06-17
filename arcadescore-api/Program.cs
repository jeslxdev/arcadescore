using arcadescore_api.Domain;
using arcadescore_api.Application;
using arcadescore_api.Infrastructure;
using arcadescore_api.Services;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = args,
    ApplicationName = typeof(Program).Assembly.FullName,
    ContentRootPath = Directory.GetCurrentDirectory(),
    WebRootPath = "wwwroot"
});
// Injeção de dependência para abstrações
builder.Services.AddSingleton<IScoreRepository, InMemoryScoreRepository>();
builder.Services.AddScoped<IScoreService, ScoreService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "ArcadeScore API", Version = "v1" });
});
builder.Services.AddCors();
var app = builder.Build();
app.Urls.Clear();
app.Urls.Add("http://localhost:8080");
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArcadeScore API v1");
    });
}
app.UseCors(policy =>
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader()
);
app.MapControllers();
app.Run();
