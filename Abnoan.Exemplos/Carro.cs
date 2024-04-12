using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    public class Carro
    {
        public string Cor { get; set; }
        public decimal Valor { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        
        public Carro()
        {
            // Inicialização padrão (opcional)
        }

        public Carro(string cor, decimal valor, string placa, string chassi)
        {
            Cor = cor;
            Valor = valor;
            Placa = placa;
            Chassi = chassi;
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...");
        }
        public void Frear()
        {
            Console.WriteLine("Carro parando...");
        }
        public void Virar(string direcao)
        {
            Console.WriteLine($"Carro virando para a {direcao}.");
        }
    }
}