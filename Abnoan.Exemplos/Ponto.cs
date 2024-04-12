using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.Exemplos
{
    public struct Ponto
    {
        public int X;
        public int Y;

        public Ponto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Deslocar(int dx, int dy)
        {
            X += dx;
            Y += dy;
        }
    }
}