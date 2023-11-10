namespace SistemaDeReserva.Model;

public class Reserva
{
    public List<Pessoa> Hospedes { get; } = new List<Pessoa>();
    public Suite Suite { get; private set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        Hospedes.AddRange(hospedes);
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valorTotal = Suite.ValorDiaria * DiasReservados;

        if (DiasReservados > 10)
        {
            valorTotal *= 0.9m; // Aplicar desconto de 10% para reservas com mais de 10 dias
        }

        return valorTotal;
    }
}