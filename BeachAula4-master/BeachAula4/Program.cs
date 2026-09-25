using DotNetshoes.Api.Application;
using DotNetshoes.Api.Data;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/api/reservas", (CriarReservaDto dto) =>
{
    try
    {
        var service = new ReservaService();
        var resultado = service.Criar(dto);
        return Results.Created($"/api/reservas/{resultado.Id}", resultado);[cite: 2, 3]
    }
    catch (ArgumentException ex)
    {
        return Results.BadRequest(ex.Message);[cite: 1]
    }
});

app.MapGet("/api/reservas", () =>
{
    using var db = new AppDbContext();
    return Results.Ok(db.Reservas.ToList());[cite: 3]
});

app.Run();