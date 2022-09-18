
using EasyBurger.API.Infra.Contexts;
using EasyBurger.API.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApiContext>(options =>
{
    var conString = builder.Configuration.GetConnectionString("MySql");
    options.UseMySql(conString, ServerVersion.AutoDetect(conString));
});

builder.Services.AddTransient<ProductRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();