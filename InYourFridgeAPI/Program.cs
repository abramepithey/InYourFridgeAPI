using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using InYourFridgeAPI.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Pizzas") ?? "Data Source=Pizzas.db";
builder.Services.AddDbContext<InYourFridgeAPIContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("InYourFridgeAPIContext") ?? throw new InvalidOperationException("Data Source=InYourFridgeAPIContext-becf042e-f8cd-4e65-bd8a-bf1a4b60bcbe.db")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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