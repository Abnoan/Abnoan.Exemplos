using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    // Definição da classe Lampada
    public class Lampada
    {
        // Atributos da classe
        public bool estado; // Estado da lâmpada: true para ligada, false para desligada
        public int intensidade; // Intensidade da luz da lâmpada

        // Construtor da classe Lampada
        public Lampada()
        {
            estado = false; // Inicializa a lâmpada como desligada
            intensidade = 0; // Inicializa a intensidade como 0
        }

        // Método para alternar o estado da lâmpada
        public void LigarDesligar()
        {
            estado = !estado; // Inverte o estado atual da lâmpada
            if (estado)
                Console.WriteLine("Lâmpada ligada.");
            else
                Console.WriteLine("Lâmpada desligada.");
        }

        // Método para ajustar a intensidade da lâmpada
        public void AjustarIntensidade(int novaIntensidade)
        {
            if (novaIntensidade < 0 || novaIntensidade > 10)
            {
                Console.WriteLine("Intensidade deve estar entre 0 e 10.");
            }
            else
            {
                intensidade = novaIntensidade; // Define a intensidade conforme o valor passado
                Console.WriteLine($"Intensidade ajustada para {intensidade}.");
            }
        }
    }
}