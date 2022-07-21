using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideralOS
{
    static class Cores
    {
        public static void CorSelecionada(TipoDeArquivo arquivo)
        {if (arquivo == TipoDeArquivo.ArquivoDeTexto)
            {
                CorArquivoDeTextoSelecionado();
            }
            else if (arquivo == TipoDeArquivo.Pasta)
            {
                CorPastaSelecionado();
            }
            else {
                CorArquivoDoSistemaSelecionado();
            }

        }


        public static void CorPadrao(TipoDeArquivo arquivo)
        {
            if (arquivo == TipoDeArquivo.ArquivoDeTexto)
            {
                CorPadraoArquivoDeTexto();

            }else if (arquivo == TipoDeArquivo.Pasta)
            {
                CorPadraoPasta();
            }
            else
            {
                CorPadraoArquivosDoSistema();
            }

        }


        public static void Rodape()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;

        }

        public static void ResetaFundo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Green;

        }


        public static void CorAviso()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

        }

        public static void CorLimparAviso()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;

        }

        private static void CorPadraoArquivoDeTexto()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void CorArquivoDeTextoSelecionado()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;

        }
        private static void CorPadraoArquivosDoSistema()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void CorArquivoDoSistemaSelecionado()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;

        }
        private static void CorPadraoPasta()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
        private static void CorPastaSelecionado()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;

        }


    }
}
