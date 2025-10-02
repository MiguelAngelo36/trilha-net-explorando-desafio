using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;


List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Miguel", sobrenome: "Angelo");
Pessoa p2 = new Pessoa(nome: "Larissa", sobrenome: "Victória");
Pessoa p3 = new Pessoa(nome: "Clarice", sobrenome: "Soares");
Pessoa p4 = new Pessoa(nome: "Laura", sobrenome: "Guereta");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 4, valorDiaria: 110);

Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");