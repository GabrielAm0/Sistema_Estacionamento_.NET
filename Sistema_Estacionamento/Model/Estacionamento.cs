namespace SistemaEstacionamentoDIO.Model;

public class Estacionamento
{
	private List<Veiculo> _veiculosEstacionados;

	public Estacionamento()
	{
		_veiculosEstacionados = new List<Veiculo>();
	}

	public void AdicionarVeiculo(Veiculo veiculo)
	{
		_veiculosEstacionados.Add(veiculo);
	}


	public void VerificarPlacaRemoveVeiculo(string placa, decimal precoInicial, decimal precoHora, int hora)
	{
		Veiculo veiculo = _veiculosEstacionados.Find(v => v.Placa == placa);

		if (veiculo == null)
		{
			Console.WriteLine("Não foram encontrados veículos com esta placa!");
		}
		else
		{
			_veiculosEstacionados.Remove(veiculo);

			Preco preco = new Preco(precoInicial, precoHora, hora);
		}
	}

	public List<Veiculo> ListarVeiculos()
	{
		return _veiculosEstacionados;
	}
}