using System;
using tabuleiro;
using xadrez;
namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);
                //Tela.ImprimirTabuleiro(tab);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 0));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }*/

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            PosicaoXadrez pos2 = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos2);
            Console.WriteLine(pos2.ToPosicao());

        }
    }
}
