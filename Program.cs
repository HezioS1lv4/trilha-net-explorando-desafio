using ConsoleApp1.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa("Hezio", "Silva");
Pessoa p2 = new Pessoa("Joao", "Paulo");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite("executiva", 3, 200.00m);

Reserva reserva = new Reserva(suite, diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor Diário: {reserva.CalcularValorDiaria().ToString("F0")}");