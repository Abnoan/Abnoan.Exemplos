using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    public class TiposPrimitivos
    {
        // Declaração de variáveis para cada tipo primitivo comum
        public int MeuInteiro { get; set; }
        public long MeuLong { get; set; }
        public byte MeuByte { get; set; }
        public short MeuShort { get; set; }
        public float MeuFloat { get; set; }
        public double MeuDouble { get; set; }
        public decimal MeuDecimal { get; set; }
        public bool MeuBool { get; set; }
        public char MeuChar { get; set; }
        public string MinhaString { get; set; }

        // Construtor que inicializa todas as variáveis com valores padrão ou exemplos
        public TiposPrimitivos()
        {
            MeuInteiro = 42;
            MeuLong = 3000000000L;
            MeuByte = 255;
            MeuShort = 32767;
            MeuFloat = 3.14f;
            MeuDouble = 3.14159;
            MeuDecimal = 3.1415926535897932384626433833m;
            MeuBool = true;
            MeuChar = 'A';
            MinhaString = "Olá, mundo!";
        }
    }
}