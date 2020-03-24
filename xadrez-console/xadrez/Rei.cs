using System;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro Tab, Cor Cor) : base(Tab, Cor)
        { 
        
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
