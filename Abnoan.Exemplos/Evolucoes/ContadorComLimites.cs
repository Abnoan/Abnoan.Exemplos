using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos.Evolucoes
{
    // Definição da classe Contador com limites
    public class ContadorComLimites
    {
        // Atributos para armazenar o valor atual do contador e seus limites
        public int valor;
        private int limiteInferior;
        private int limiteSuperior;

        // Construtor da classe Contador
        public ContadorComLimites()
        {
            valor = 0; // Inicializa o contador com o valor 0
        }

        // Método para definir os limites do contador
        public void DefinirLimites(int inferior, int superior)
        {
            limiteInferior = inferior;
            limiteSuperior = superior;
            Console.WriteLine($"Limites definidos: inferior = {limiteInferior}, superior = {limiteSuperior}");
        }

        // Método para incrementar o valor do contador
        public void Incrementar()
        {
            if (valor < limiteSuperior)
            {
                valor++; // Aumenta o valor do contador em um
                Console.WriteLine($"Valor incrementado: {valor}");
            }
            else
            {
                Console.WriteLine("Limite superior atingido, não é possível incrementar.");
            }
        }

        // Método para decrementar o valor do contador
        public void Decrementar()
        {
            if (valor > limiteInferior)
            {
                valor--; // Diminui o valor do contador em um
                Console.WriteLine($"Valor decrementado: {valor}");
            }
            else
            {
                Console.WriteLine("Limite inferior atingido, não é possível decrementar.");
            }
        }
    }
}