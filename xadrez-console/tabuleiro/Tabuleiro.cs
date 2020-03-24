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

        //Sobrecarga do método Pecas_Tab
        public Peca Pecas_Tab(Posicao pos)
        {
            return Pecas[pos.Linhas, pos.Colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (ExistePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nesta posição!");
            }
            Pecas[pos.Linhas, pos.Colunas] = p;
            p.Posicao = pos;
        }

        public Peca RetirarPeca(Posicao pos)
        {
            if (Pecas_Tab(pos) == null)
            {
                return null;
            }
            Peca aux = Pecas_Tab(pos);
            aux.Posicao = null;
            Pecas[pos.Linhas, pos.Colunas] = null;
            return aux;
        
        }


        public bool ExistePeca(Posicao pos)
        {
            ValidarPosicao(pos);
            return Pecas_Tab(pos) != null;
        }

        //Método que verifica se a posição é válida
        public bool PosicaoValida(Posicao pos)
        {
            if ((pos.Linhas < 0) || (pos.Linhas >= Linhas) || (pos.Colunas < 0) || (pos.Colunas >= Colunas))
            {
                return false;
            }
            return true; //não é necessário colocar o else pois o return corta a execução.
        }

        //Método para validar a posição
        public void ValidarPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }


    }

    
}
