using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    // Definição da classe Carro
    public class Carro
    {
        // Atributos da classe
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public string Placa { get; set; }
        public int VelocidadeAtual { get; private set; }

        // Construtores
        public Carro()
        {
            // Inicialização Padrão
        }
        public Carro(string modelo, string cor, int ano, string placa)
        {
            Modelo = modelo;
            Cor = cor;
            Ano = ano;
            Placa = placa;
            VelocidadeAtual = 0; // Inicializa a velocidade do carro como 0
        }

        // Método para acelerar o carro
        public void Acelerar(int incremento)
        {
            VelocidadeAtual += incremento;
            Console.WriteLine($"Acelerando: a velocidade atual é {VelocidadeAtual} km/h.");
        }

        // Método para frear o carro
        public void Frear(int decremento)
        {
            if (VelocidadeAtual > 0 && decremento <= VelocidadeAtual)
            {
                VelocidadeAtual -= decremento;
                Console.WriteLine($"Freando: a velocidade atual é {VelocidadeAtual} km/h.");
            }
            else
            {
                Console.WriteLine("Operação inválida: o carro já está parado ou o decremento é maior que a velocidade atual.");
            }
        }

        // Método para virar o Carro
        public void Virar(string direcao)
        {
            Console.WriteLine($"Carro virando para a {direcao}.");
        }
    }
}