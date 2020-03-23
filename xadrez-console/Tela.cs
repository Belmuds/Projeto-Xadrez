using System;
using tabuleiro;

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
                for (int j = 0; j < Tab.Linhas; j++)
                {
                    if (Tab.Pecas_Tab(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else 
                    {
                        Console.Write(Tab.Pecas_Tab(i,j) + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
