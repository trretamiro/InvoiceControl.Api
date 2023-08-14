using InvoiceControl.Api.Configurations;
using InvoiceControl.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", true, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables();

// WebAPI Config
builder.Services.AddControllers();

// Setting DBContexts
//builder.Services.AddDatabaseConfiguration(builder.Configuration);
//Problema para rodar o migrations então a configuração ficou assim : =>
string stringDeConexao = builder.Configuration.GetConnectionString("InvoiceConnection")!;
builder.Services.AddDbContext<InvoiceContext>(db => db.UseSqlServer(stringDeConexao));

//DI Abstraction
builder.Services.AddDependencyInjectionConfiguration();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

// AutoMapper Settings
builder.Services.AddAutoMapperConfiguration();

// Swagger Config
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
