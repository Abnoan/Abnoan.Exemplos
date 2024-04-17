using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    // Definição da classe Termômetro
    public class Termometro
    {        
        // Atributo para armazenar a temperatura atual
        public double temperatura;

        // Construtor da classe Termômetro
        public Termometro()
        {
            temperatura = 0.0; // Inicializa a temperatura com 0.0 graus
        }

        // Método para ajustar a temperatura do termômetro
        public void AjustarTemperatura(double novaTemperatura)
        {
            temperatura = novaTemperatura; // Define a temperatura para o valor especificado
            Console.WriteLine($"Temperatura ajustada para {temperatura} graus.");
        }

        // Método para mostrar a temperatura atual no console
        public void MostrarTemperatura()
        {
            Console.WriteLine($"Temperatura atual: {temperatura} graus.");
        }
    }
}