using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos.Evolucoes
{
  // Definição da classe Termômetro com alertas
public class TermometroComAlerta
{
    // Atributos para armazenar a temperatura atual e as temperaturas mínima e máxima
    public double temperatura;
    private double temperaturaMinima;
    private double temperaturaMaxima;

    // Construtor da classe Termômetro
    public TermometroComAlerta()
    {
        temperatura = 0.0; // Inicializa a temperatura com 0.0 graus
    }

    // Método para definir a faixa de temperatura desejável
    public void DefinirFaixaDeTemperatura(double minima, double maxima)
    {
        temperaturaMinima = minima;
        temperaturaMaxima = maxima;
        Console.WriteLine($"Faixa de temperatura definida de {temperaturaMinima} a {temperaturaMaxima} graus.");
    }

    // Método para ajustar a temperatura do termômetro
    public void AjustarTemperatura(double novaTemperatura)
    {
        if (novaTemperatura < temperaturaMinima || novaTemperatura > temperaturaMaxima)
        {
            Console.WriteLine($"Alerta: Temperatura {novaTemperatura} fora da faixa permitida de {temperaturaMinima} a {temperaturaMaxima} graus.");
        }
        else
        {
            temperatura = novaTemperatura; // Define a temperatura para o valor especificado
            Console.WriteLine($"Temperatura ajustada para {temperatura} graus.");
        }
    }

    // Método para mostrar a temperatura atual e alertas, se necessário
    public void MostrarTemperatura()
    {
        Console.WriteLine($"Temperatura atual: {temperatura} graus.");
        if (temperatura < temperaturaMinima || temperatura > temperaturaMaxima)
        {
            Console.WriteLine("Alerta: A temperatura atual está fora da faixa desejada!");
        }
    }
}
}