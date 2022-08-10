using System.Text;
using DesafioProjetoHospedagem.Models;
using System.Globalization;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new(nome: "Daniel Visicatto");
Pessoa p2 = new(nome: "Ana Paula Visicatto");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 33.27m);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("F2")}");
