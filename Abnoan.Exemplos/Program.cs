using Abnoan.Exemplos;

public class Program
{
    static void Main()
    {
        Ponto p = new Ponto(1, 2);
        p.Deslocar(3, 4);
        Console.WriteLine($"Novo ponto está em ({p.X}, {p.Y}).");

        Carro meuCarro = new Carro("Vermelho", 50000m, "ABC-1234", "1HGBH41JXMN109186");
        
        Carro meuOutroCarro = new("Azul", 40000m, "AAD4F7", "2HGBH41JXMN109186");

        Carro meuTerceiroCarro = new Carro();
        meuCarro.Cor = "Azul";
        meuCarro.Valor = 30000m;
        meuCarro.Placa = "DEF-5678";
        meuCarro.Chassi = "2HGBH41JXMN109187";

        Carro meuQuartoCarro = new()
        {
            Cor = "Rosa",
            Chassi = "2HGBH41JXMN109182",
            Placa = "KGB-1071",
            Valor = 60000m
        };
    }
}