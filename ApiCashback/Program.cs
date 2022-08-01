using ApiCashback.Data;
using ApiCashback.Services.Interfaces;
using CashBack.Repositories;
using CashBack.Repositories.Interfaces;
using CashBack.Services;
using CashBack.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionstring));

builder.Services.AddScoped<ICashBackPercentualRepository, CashBackPercentualRepository>();
builder.Services.AddScoped<ICatalogoCervejaRepository, CatalogoCervejaRepository>();
builder.Services.AddScoped<IVendaRepository, VendaRepository>();
builder.Services.AddScoped<ICashBackPercentualService, CashBackPercentualService>();
builder.Services.AddScoped<ICatalogoCervejaService, CatalogoCervejaService>();
builder.Services.AddScoped<IVendaService, VendaService>();

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
