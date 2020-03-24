using System;


namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca Pecas_Tab(int linhas, int colunas)
        {
            return Pecas[linhas, colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }
    }

    
}
