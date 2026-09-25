using Microsoft.EntityFrameworkCore;
using DotNetshoes.Api.Domain;

namespace DotNetshoes.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<Reserva> Reservas => Set<Reserva>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=dotnetshoes.db");[cite: 3]
    }
}