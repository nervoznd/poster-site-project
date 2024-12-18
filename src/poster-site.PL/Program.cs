using DotNetEnv;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

string connectionString = Environment.GetEnvironmentVariable("DATABASE_URL");

builder.Services.AddDbContext<poster_site.DAL.PosterSiteDbContext>(options => options.UseNpgsql(connectionString));

// Add services to the container.
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.Run();
