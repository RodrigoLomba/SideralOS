using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.HAL;
using Cosmos.System.Network.Config;

namespace SideralOS
{
    public class Tela
    {
        public static string YearString()
        {
            int intyear = Year();
            string stringyear = intyear.ToString();

            if (stringyear.Length == 2)
            {
                stringyear = "20" + stringyear;
            }
            return stringyear;
        }


        static int Hour() { return RTC.Hour; }

        static int Minute() { return RTC.Minute; }

        static int Second() { return RTC.Second; }

        static int Year() { return RTC.Year; }

        static int Month() { return RTC.Month; }

        static int DayOfMonth() { return RTC.DayOfTheMonth; }

        static int DayOfWeek() { return RTC.DayOfTheWeek; }


        private List<ItensMenu> itensMenus;

        public Tela()
        {
            Cores.ResetaFundo();
            Console.Clear();
            Rodape();
        }

        private void Rodape()
        {
            //Console.BackgroundColor = ConsoleColor.Black;
            Cores.Rodape();
            
            PreencheLinhaVazia(Console.WindowHeight -25);
            //PreencheLinhaVazia(Console.WindowHeight -24);

            Console.SetCursorPosition(0,Console.WindowHeight -25);
           // Console.Write("                                     " + Hour() + ":" + Minute());
            Console.SetCursorPosition(0, Console.WindowHeight - 25);
            Console.Write("                            " + "DIA "      + DayOfMonth() + " DE " + "JULHO" + " DE " + "20" + Year() + "                        " + Hour() + ":" + Minute());
            AtualizaTela();
        }


        public void AtualizaTela()
        {
            itensMenus = new ItensMenu().RetornaItens();
            
            for (int i = 0; i < itensMenus.Count; i++)
            {
                if (ItensMenu.PosicaoItemAtual == i)
                {
                    Cores.CorSelecionada(itensMenus[i].TipoDeArquivo);
                }
                else
                {
                    Cores.CorPadrao(itensMenus[i].TipoDeArquivo);
                }
                Console.SetCursorPosition(itensMenus[i].posição.X, itensMenus[i].posição.Y);
                Console.Write(itensMenus[i].Nome);
                
            }
          // Rodape();
        }


        public void Up()
        {if (ItensMenu.PosicaoItemAtual > 0)
            {
                ItensMenu.PosicaoItemAtual--;
                AtualizaTela();
                Rodape();
            }
        }


        public void Down()
        {
            if(ItensMenu.PosicaoItemAtual < itensMenus.Count -1)
            {
                ItensMenu.PosicaoItemAtual++;
                AtualizaTela();
                Rodape();
            }

        }

        public static void PreencheLinhaVazia(int linha)
        {
            Console.SetCursorPosition(0, linha);
            Console.Write(new String(' ', Console.WindowWidth));

        }

        public static string MostrarMensagemUsuarioEAguardar(string aviso)
        {
            Cores.CorAviso();
            PreencheLinhaVazia(Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 6);
            Console.Write("   " + aviso);
            return Console.ReadLine().Trim();
        }
        public static void MostrarMensagemUsuario(string aviso)
        {
            Cores.CorAviso();
            PreencheLinhaVazia(Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 6);
            Console.Write("   " + aviso);

        }
        public static void LimparAreaMensagem()
        {
            Cores.CorLimparAviso();
            PreencheLinhaVazia(Console.WindowHeight - 9);
            PreencheLinhaVazia(Console.WindowHeight - 8);
            PreencheLinhaVazia(Console.WindowHeight - 7);
            PreencheLinhaVazia(Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 9);

        }

        public static void PrepararAreaMensagem()
        {
            Cores.CorAviso();
            PreencheLinhaVazia(Console.WindowHeight - 9);
            PreencheLinhaVazia(Console.WindowHeight - 8);
            PreencheLinhaVazia(Console.WindowHeight - 7);
            PreencheLinhaVazia(Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 9);
            
        }

        public static void PrepararAreaMensagem(string conteudo)
        {
            Cores.CorAviso();
            PreencheLinhaVazia(Console.WindowHeight - 9);
            PreencheLinhaVazia(Console.WindowHeight - 8);
            PreencheLinhaVazia(Console.WindowHeight - 7);
            PreencheLinhaVazia(Console.WindowHeight - 6);
            Console.SetCursorPosition(0, Console.WindowHeight - 9);
            Console.Write(conteudo);
        }

    }
}