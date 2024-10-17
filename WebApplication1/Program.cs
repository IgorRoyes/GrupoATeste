using GrupoAEducacao.Business.Interfaces;
using GrupoAEducacao.Business.Services;
using GrupoAEducacao.Domain.Data;
using GrupoAEducacao.Domain.Interfaces;
using GrupoAEducacao.Domain.Models;
using GrupoAEducacao.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<StudentContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=Kumoichi15"));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
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
