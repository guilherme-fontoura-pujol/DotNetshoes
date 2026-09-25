using DotNetshoes.Api.Data;
using DotNetshoes.Api.Domain;

namespace DotNetshoes.Api.Application;

public class ReservaService
{
    public CriarReservaResult Criar(CriarReservaDto dto)
    {
        // Instancia e executa as validações do Domínio
        var reserva = new Reserva(dto.ClienteId, dto.QuadraId, dto.Inicio, dto.Fim);

        using var db = new AppDbContext();
        db.Reservas.Add(reserva);
        db.SaveChanges();

        return new CriarReservaResult(reserva.Id, reserva.Inicio, reserva.Fim, reserva.Valor);[cite: 2]
    }
}