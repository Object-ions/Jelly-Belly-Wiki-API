using JellyBellyWikiApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<JellyBellyWikiApiContext>(
                  dbContextOptions => dbContextOptions
                    .UseMySql(
                      builder.Configuration["ConnectionStrings:DefaultConnection"], 
                      ServerVersion.AutoDetect(builder.Configuration["ConnectionStrings:DefaultConnection"]
                    )
                  )
                );

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
      {
        options.AddDefaultPolicy(
            policy =>
            {

              policy.AllowAnyOrigin();
              policy.AllowAnyHeader();
              policy.AllowAnyMethod();
            });
      });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else 
{
  app.UseHttpsRedirection();
}

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();