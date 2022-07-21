using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideralOS
{
    class Posição
    {
        public int X { get; set; }

        public int Y { get; set; }


        private static int xAtual = 2;

        private static int yAtual = 0;

        public Posição(int x, int y)
        {
            X = x;
            Y = y;
        }


        public static void IncrementaY()
        {
            yAtual++;
        }
        public static void ResetaPosicaoAtual()
        {
            xAtual = 2;
            yAtual = 0;
        }

        public static Posição RetornaPosicao()
        {
            int y;

            if (yAtual > Console.WindowHeight /2 - 7)
            {
                yAtual = 0;
                xAtual = 22;

            }

            y = 2 + (2 * yAtual);

            return new Posição(xAtual, y);


        }


    }

    

}

