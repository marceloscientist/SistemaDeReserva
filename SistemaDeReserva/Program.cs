using SistemaDeReserva.Model;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("João", "Silva");
        Pessoa pessoa2 = new Pessoa("Maria", "Pereira");

        Suite suite = new Suite("Suite Presidencial", 4, 500.0m);

        Reserva reserva = new Reserva();
        reserva.CadastrarHospedes(new List<Pessoa> { pessoa1, pessoa2 });
        reserva.CadastrarSuite(suite);
        reserva.DiasReservados = 12;

        Console.WriteLine("Reserva para " + reserva.ObterQuantidadeHospedes() + " hóspedes na " + suite.TipoSuite);
        Console.WriteLine("Valor da diária: R$" + suite.ValorDiaria);
        Console.WriteLine("Número de dias reservados: " + reserva.DiasReservados);
        Console.WriteLine("Valor total da reserva: R$" + reserva.CalcularValorDiaria());
    }
}