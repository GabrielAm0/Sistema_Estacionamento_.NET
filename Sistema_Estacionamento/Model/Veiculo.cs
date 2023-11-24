namespace SistemaEstacionamentoDIO.Model;

public class Veiculo
{
	public string Placa { get; set; }
	public string Marca { get; set; }
	public string Modelo { get; set; }
	
	
	public Veiculo(string placa, string marca, string modelo)
	{
		Placa = placa;
		Marca = marca;
		Modelo = modelo;
	}
	
	public override string ToString()
	{
		return $"Placa: {Placa}, Marca: {Marca}, Modelo: {Modelo}";
	}
}