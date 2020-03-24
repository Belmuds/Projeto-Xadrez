using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Tela
    {   /*
        operação estática sempre vai dar o mesmo resultado independetemente
        de objeto, ao contrário das operações dinâmicas

        Membros static não precisam instanciar objetos para serem chamados justamente
        porque não possuem dependência de objetos.

        A chamada destes objetos é feito diretamente do nome da classe e não mais
        de objetos instanciados

        As operaçãoes são idenpendentes de objetos.
         */
        public static void ImprimirTabuleiro(Tabuleiro Tab)
        {
            for (int i = 0; i < Tab.Colunas; i++)
            {
                Console.Write(Tab.Colunas - i + " ");
                for (int j = 0; j < Tab.Linhas; j++)
                {
                    
                    if (Tab.Pecas_Tab(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else 
                    {
                        ImprimirPeca(Tab.Pecas_Tab(i, j));
                        //Console.WriteLine();
                    }
                }
                Console.WriteLine();
            }
           // Console.WriteLine("  a b c d e f g h");
        }

        public static PosicaoXadrez LerPosicaoXadrez()
        {
            string s = Console.ReadLine();
            char coluna = s[0];
            int linha = int.Parse(s[1] + "");
            return new PosicaoXadrez(coluna,linha);
        }




        public static void ImprimirPeca(Peca Peca)
        {
            if (Peca.Cor == Cor.Branca)
            {
                Console.Write(Peca + " ");
            } 
            else 
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(Peca + " ");
                Console.ForegroundColor = aux;
            }
        }
    }
}
