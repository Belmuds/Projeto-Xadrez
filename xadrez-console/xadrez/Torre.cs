﻿using System;
using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro Tab, Cor Cor) : base(Tab, Cor)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}