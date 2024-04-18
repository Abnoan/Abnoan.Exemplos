using Abnoan.Exemplos;

public class Program
{
    static void Main()
    {
        #region Construtores

        Carro meuCarro = new Carro("Fiat Uno", "Vermelho", 2021, "ABC-1234");

        Carro meuOutroCarro = new("Honda Civic", "Azul", 2020, "AAD4F7");

        Carro meuTerceiroCarro = new Carro();
        meuTerceiroCarro.Modelo = "Toyota Corolla";
        meuTerceiroCarro.Cor = "Preto";
        meuTerceiroCarro.Ano = 2023;
        meuTerceiroCarro.Placa = "DEF-5678";

        Carro meuQuartoCarro = new()
        {
            Modelo = "Fusca",
            Cor = "Azul",
            Ano = 1958,
            Placa = "KGB-1071"
        };

        #endregion

        #region Classe Lampada
        // Criação de um objeto minhaLampada da classe Lampada
        Lampada minhaLampada = new Lampada();

        // Utiliza o método LigarDesligar para ligar a lâmpada
        minhaLampada.LigarDesligar();

        // Ajusta a intensidade da lâmpada para 5
        minhaLampada.AjustarIntensidade(5);

        // Imprime no console o estado e a intensidade da lâmpada
        Console.WriteLine($"Estado atual: {(minhaLampada.estado ? "Ligada" : "Desligada")}");
        Console.WriteLine($"Intensidade atual: {minhaLampada.intensidade}");
        #endregion

        #region  Classe Contador
        // Criação de um objeto meuContador da classe Contador
        Contador meuContador = new Contador();

        // Incrementa o valor do contador três vezes
        meuContador.Incrementar();
        meuContador.Incrementar();
        meuContador.Incrementar();

        // Decrementa o valor do contador uma vez
        meuContador.Decrementar();

        // Imprime no console o valor final do contador
        Console.WriteLine($"Valor final do contador: {meuContador.valor}");
        #endregion

        #region Classe Termômetro
        // Criação de um objeto termometroCasa da classe Termometro
        Termometro termometroCasa = new Termometro();

        // Ajusta a temperatura para 26.5 graus
        termometroCasa.AjustarTemperatura(26.5);

        // Utiliza o método MostrarTemperatura para exibir a temperatura no console
        termometroCasa.MostrarTemperatura();
        #endregion

        #region Classe Sala
        Sala minhaSala = new Sala();
        minhaSala.AdicionarLampada(new Lampada());
        minhaSala.AdicionarLampada(new Lampada());
        minhaSala.AdicionarLampada(new Lampada());

        minhaSala.LigarTodasLampadas();
        minhaSala.AjustarIntensidadeTodas(7);
        minhaSala.ImprimirEstadoLampadas();
        #endregion
    }
}