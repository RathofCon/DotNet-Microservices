// 05:42
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Mvc;
global using AutoMapper;
global using System.ComponentModel.DataAnnotations;

global using PlatformService.Data;

global using PlatformService.Models;
global using PlatformService.SyncDataServices.Http;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<IPlatformRepo, PlatformRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddHttpClient<ICommandDataClient, HttpCommandDataClient>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(
  opt => opt.UseInMemoryDatabase("InMemory"));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    Console.WriteLine("-->In Memory Server");
    Console.WriteLine($"--> Command Service Endpoint {builder.Configuration["CommandService"]}");
}
else{
    Console.WriteLine("-->Using SQL Server DB");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//PrepDb.PrepPopulation(app);
app.Run();
