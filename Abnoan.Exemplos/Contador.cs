using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    // Definição da classe Contador
    public class Contador
    {
        // Atributo para armazenar o valor atual do contador
        public int valor;

        // Construtor da classe Contador
        public Contador()
        {
            valor = 0; // Inicializa o contador com o valor 0
        }

        // Método para incrementar o valor do contador
        public void Incrementar()
        {
            valor++; // Aumenta o valor do contador em um
            Console.WriteLine($"Valor incrementado: {valor}");
        }

        // Método para decrementar o valor do contador
        public void Decrementar()
        {
            valor--; // Diminui o valor do contador em um
            Console.WriteLine($"Valor decrementado: {valor}");
        }
    }
}