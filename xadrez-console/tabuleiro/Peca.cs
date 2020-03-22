using System;
using tabuleiro;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        private int linhas;
        private int colunas;

        public Posicao Posicao { get; set; }
        public Cor Cor { get; set; }
        public int QtdMovimentos { get; protected set; }//Só pode ser alterado por ela e pelas suas sub-classes
        public Tabuleiro Tab { get;protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            Posicao = posicao;
            Cor = cor;
            Tab = tab;
            QtdMovimentos = 0;
        }

        
    }

    
}
