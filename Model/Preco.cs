namespace SistemaEstacionamentoDIO.Model;

public class Preco
{
	public decimal ValorFixo { get; set; }
	public decimal ValorHora { get; set; }
	public int HorasEstacionado { get; set; }

	public Preco(decimal valorFixo, decimal valorHora, int horas)
	{
		ValorFixo = valorFixo;
		ValorHora = valorHora;
		HorasEstacionado = horas;

		decimal preco = ValorFixo + (ValorHora * HorasEstacionado);
		
		Console.WriteLine($"Veículo removido com sucesso, o preço a ser pago é {preco}!");

	}
}