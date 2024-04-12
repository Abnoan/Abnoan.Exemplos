using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    public class ModificadoresDeAcesso
    {
        // Acessível de qualquer lugar.
        public int AtributoPublico;
        // Acessível apenas dentro da classe.
        private int AtributoPrivado;
        // Acessível dentro da classe e por classes derivadas.
        protected int AtributoProtegido;
    }
}