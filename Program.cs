using Microsoft.EntityFrameworkCore;
using TodoAPI.Context;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
    builder => builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});
// Add services to the container.

builder.Services.AddDbContext<TodoDbContext>(options =>
    options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors("AllowOrigin");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
