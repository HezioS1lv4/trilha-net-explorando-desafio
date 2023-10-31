namespace ConsoleApp1.Models;
public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva(Suite suite, int diasReservados)
    {
        Suite = suite;
        DiasReservados = diasReservados;
        Hospedes = new List<Pessoa>();
    }
    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite.Capacidade >= hospedes.Count)
            Hospedes = hospedes;
        else
        {
            throw new Exception("Capacidade menor do que o numero de hóspedes recebidos");
        }
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
        decimal valor = DiasReservados * Suite.ValorDiaria;

        if(DiasReservados >= 10)
        {
            decimal desconto = 0.10m * valor;
            valor = valor - desconto;
        }
        return valor;
    }
}

