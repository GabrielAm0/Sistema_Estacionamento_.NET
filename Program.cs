using SistemaEstacionamentoDIO.Model;

Estacionamento estacionamento = new Estacionamento();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.WriteLine("Digite o preço inicial:");
decimal precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço da hora:");
decimal precoHora = Convert.ToDecimal(Console.ReadLine());

while (true)
{
	Console.WriteLine("Escolha uma opção:");
	Console.WriteLine("1. Adicionar Veículo");
	Console.WriteLine("2. Remover Veículo");
	Console.WriteLine("3. Listar Veículos");
	Console.WriteLine("4. Sair");

	int escolha = int.Parse(Console.ReadLine());

	switch (escolha)
	{
		case 1:
			AdicionarVeiculo(estacionamento);
			break;
		case 2:
			RemoverVeiculo(estacionamento, precoInicial, precoHora);
			break;
		case 3:
			ListarVeiculos(estacionamento);
			break;
		case 4:
			Console.WriteLine("Saindo do sistema...");
			return;
		default:
			Console.WriteLine("Opção inválida. Tente novamente.");
			break;
	}

	Console.WriteLine();
}


static void AdicionarVeiculo(Estacionamento estacionamento)
{
	Console.WriteLine("Digite a placa do veículo:");
	string placa = Console.ReadLine();
	
	Console.WriteLine("Digite a marca do veículo:");
	string marca = Console.ReadLine();
	
	Console.WriteLine("Digite o modelo do veículo:");
	string modelo = Console.ReadLine();
	
	Veiculo veiculo = new Veiculo(placa, marca, modelo);
	estacionamento.AdicionarVeiculo(veiculo);
	
	Console.WriteLine("Veículo adicionado com sucesso!");
}


static void RemoverVeiculo(Estacionamento estacionamento, decimal precoInicial, decimal precoHora )
{
	Console.WriteLine("Digite a placa do veículo:");
	string placa = Console.ReadLine();
	
	Console.WriteLine("Digite quantas horas o veículo ficou estacionado:");
	int hora = int.Parse(Console.ReadLine());
	
	estacionamento.VerificarPlacaRemoveVeiculo(placa, precoInicial, precoHora, hora);
}

static void ListarVeiculos(Estacionamento estacionamento)
{
	List<Veiculo> veiculos = estacionamento.ListarVeiculos();
	
	if (veiculos.Count == 0)
	{
		Console.WriteLine("Não há veículos estacionados!");
	}
	else
	{
		Console.WriteLine("Veículos estacionados:");

		foreach (Veiculo veiculo in veiculos)
		{
			Console.WriteLine(veiculo);
		}
	}
}