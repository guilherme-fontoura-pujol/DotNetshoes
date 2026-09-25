namespace DotNetshoes.Api.Domain;

public class Reserva
{
    public int Id { get; private set; }
    public int ClienteId { get; private set; }
    public int QuadraId { get; private set; }
    public DateTime Inicio { get; private set; }
    public DateTime Fim { get; private set; }
    public decimal Valor { get; private set; }

    public Reserva(int clienteId, int quadraId, DateTime inicio, DateTime fim)
    {
        if (fim <= inicio)
            throw new ArgumentException("O horário final deve ser posterior ao inicial.");

        ClienteId = clienteId;
        QuadraId = quadraId;
        Inicio = inicio;
        Fim = fim;
        
        // Regra de negócio simples do domínio:
        Valor = (fim - inicio).Hours * 100m;
    }
}