using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
using System;

// Definição da classe Documento
public class Documento
{
    // Público: Acessível de qualquer parte do código que possa ver a classe Documento
    public string Titulo { get; set; }

    // Privado: Acessível apenas dentro da classe Documento
    private string Conteudo { get; set; }

    // Protegido: Acessível dentro da classe Documento e em classes derivadas
    protected DateTime DataCriacao { get; set; }

    // Interno: Acessível apenas dentro do mesmo assembly (projeto), mas não fora dele
    internal string Autor { get; set; }

    // Construtor da classe Documento
    public Documento(string titulo, string conteudo, string autor)
    {
        Titulo = titulo;
        Conteudo = conteudo;
        Autor = autor;
        DataCriacao = DateTime.Now;
    }
}

// Uma classe derivada para demonstrar acesso protegido
public class Relatorio : Documento
{
    public Relatorio(string titulo, string conteudo, string autor)
        : base(titulo, conteudo, autor)
    {
    }

    public void PrintDataCriacao()
    {
        // Acesso ao atributo protegido da classe base
        Console.WriteLine($"Data de Criação: {DataCriacao}");
    }
}

}