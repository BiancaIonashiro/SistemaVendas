using SistemaVendas.Dominio.Interfaces.Repository;
using SistemaVendas.Infra.Data.Odbc.Sql.Repositorios.Geral;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//TODO: Injetar servicos IOC 
//builder.Services.AddTransient<IGrupoUnidadeMedidaOdbcRepository, GrupoUnidadeMedidaOdbcRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
