using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// ✅ Keep default configuration, but disable file watching in Production
builder.Host.ConfigureAppConfiguration((context, config) =>
{
    if (context.HostingEnvironment.IsProduction())
    {
        foreach (var source in config.Sources.OfType<JsonConfigurationSource>())
        {
            source.ReloadOnChange = false;
        }
    }
});

builder.Services.AddControllers();

var connStr = builder.Configuration.GetConnectionString("DefaultConnection")
             ?? builder.Configuration["ConnectionStrings:DefaultConnection"];

builder.Services.AddDbContext<JellyBellyWikiApiContext>(dbContextOptions =>
    dbContextOptions.UseMySql(
        connStr,
        ServerVersion.AutoDetect(connStr)
    )
);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// On Render, HTTPS is terminated at the proxy.
// This can cause issues if your app tries to redirect internally.
// Safer to only enable this locally/dev, or configure forwarded headers.
if (!app.Environment.IsProduction())
{
    app.UseHttpsRedirection();
}

app.UseCors();
app.UseAuthorization();

app.MapControllers();

app.Run();
