using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    // Definição da classe Sala
    public class Sala
    {
        // Lista para armazenar as lâmpadas
        private List<Lampada> lampadas = new List<Lampada>();

        // Método para adicionar lâmpadas à sala
        public void AdicionarLampada(Lampada lampada)
        {
            lampadas.Add(lampada);
        }

        // Método para ligar todas as lâmpadas da sala
        public void LigarTodasLampadas()
        {
            foreach (Lampada lamp in lampadas)
            {
                lamp.estado = true;
            }
        }

        // Método para desligar todas as lâmpadas da sala
        public void DesligarTodasLampadas()
        {
            foreach (Lampada lamp in lampadas)
            {
                lamp.estado = false;
            }
        }

        // Método para ajustar a intensidade de todas as lâmpadas
        public void AjustarIntensidadeTodas(int intensidade)
        {
            foreach (Lampada lamp in lampadas)
            {
                lamp.AjustarIntensidade(intensidade);
            }
        }

        // Método para imprimir o estado de todas as lâmpadas
        public void ImprimirEstadoLampadas()
        {
            foreach (Lampada lamp in lampadas)
            {
                Console.WriteLine($"Lâmpada está {(lamp.estado ? "ligada" : "desligada")} com intensidade {lamp.intensidade}.");
            }
        }
    }
}