using Dining.Models;
using Dining.Models.Interfaces;
using Dining.Repository.Interfaces;
using Dining.Repository.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

IConfiguration configuration = new ConfigurationBuilder()
    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
    .AddJsonFile("appsettings.json")
    .Build();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<RestaurantDiningContext>(options =>
         options.UseSqlServer(configuration.GetConnectionString("Dev"), b => b.MigrationsAssembly("Dining.Infrastructure")));
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<ISQLServerDiningRepository<IEntity>, SQLServerDiningRepository<IEntity>>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
