using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;
using System.Drawing;
using SideralOS;
using IL2CPU.API.Attribs;
using Cosmos.System.Graphics;
using System.Resources;
using System.Runtime.InteropServices;
using System.Reflection;
using System.IO;
using Cosmos.System.Network.Config;
using Cosmos.HAL;
using Cosmos.System.FileSystem.Listing;

using System.Data;

using System.Linq;

using System.Threading.Tasks;
using Cosmos.Core.IOGroup;

namespace SideralOS
{

    public class Kernel : Sys.Kernel
    {
        private ItensMenu itens;
        private Tela tela;



        public static string langSelected = "en_US";


        //Canvas canvas;


        protected override void BeforeRun()
        {




            Diretorio.CriarSistemaArquivo();
            Console.Clear();
            Console.CursorVisible = false;
            itens = new ItensMenu();
            tela = new Tela();
            tela.AtualizaTela();
            // canvas = FullScreenCanvas.GetFullScreenCanvas();



            Console.Clear();
            Console.CursorVisible = false;

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("---------------------------INICIADO COM SUCESSO---------------------------");
            Thread.Sleep(800);
            Thread.Sleep(300);
            Console.WriteLine("SideralOS versao 0.0.0.1");
            Thread.Sleep(600);
            Console.WriteLine("Efetuando verificacao...");
            Thread.Sleep(600);

            Console.Write("Checando RAM = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(600);
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(600);




            Console.Write("Checando CPU = ");
            Console.ForegroundColor = ConsoleColor.Green;
            Thread.Sleep(600);
            Console.WriteLine("OK");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(600);

            Console.Write("Checando rede = ");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(600);
            Console.WriteLine("Nenhuma rede detectada");
            Thread.Sleep(600);


            Console.ForegroundColor = ConsoleColor.Gray;


            Console.Write("Checando Armazenamento = ");
            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(700);
            Console.WriteLine("Nada Encontrado");

            Thread.Sleep(700);
            Console.Write("Nenhum Armazenamento Encontrado: ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("...");
            Thread.Sleep(700);
            Console.Write("...");
            Thread.Sleep(700);
            Console.Clear();




            Console.ForegroundColor = ConsoleColor.White;



            Console.Write("                             Username: ");


            string typuser = string.Empty;
            string typpass = string.Empty;
            typuser = Console.ReadLine();

            Console.Clear();

            Console.Write("                             Password: ");

          
            string typuser2 = string.Empty;
            string typpass2 = string.Empty;
            typuser2 = Console.ReadLine();
            Console.Clear();

            if (typuser == "Rodrigo" && typuser2 == "2022")
            {

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.Write("");
                Console.Write("");
                Console.Write("                             SEJA BEM-VINDO!");
                Console.Write("");
                Console.Write("");






                Thread.Sleep(2000);
                Console.Clear();


                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("");



                Thread.Sleep(2000);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.Write("");
                Console.Write("");
                Console.Write("                             ACESSO NEGADO!");
                Console.Write("");
                Console.Write("");

                Thread.Sleep(1000);
                Console.Clear();

                Sys.Power.Reboot(); 



                //Login login = new Login();  


            }


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
           // Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@"


 $$$$$$\  $$\       $$\                              $$\  $$$$$$\   $$$$$$\  
$$  __$$\ \__|      $$ |                             $$ |$$  __$$\ $$  __$$\ 
$$ /  \__|$$\  $$$$$$$ | $$$$$$\   $$$$$$\  $$$$$$\  $$ |$$ /  $$ |$$ /  \__|
\$$$$$$\  $$ |$$  __$$ |$$  __$$\ $$  __$$\ \____$$\ $$ |$$ |  $$ |\$$$$$$\  
 \____$$\ $$ |$$ /  $$ |$$$$$$$$ |$$ |  \__|$$$$$$$ |$$ |$$ |  $$ | \____$$\ 
$$\   $$ |$$ |$$ |  $$ |$$   ____|$$ |     $$  __$$ |$$ |$$ |  $$ |$$\   $$ |
\$$$$$$  |$$ |\$$$$$$$ |\$$$$$$$\ $$ |     \$$$$$$$ |$$ | $$$$$$  |\$$$$$$  |
 \______/ \__| \_______| \_______|\__|      \_______|\__| \______/  \______/ 
                                                        
");


            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Thread.Sleep(400);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(400);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("...");
            Thread.Sleep(1000);
            Thread.Sleep(1000);
            Console.Clear();
            itens = new ItensMenu();
            tela = new Tela();
            tela.AtualizaTela();




        }

        protected override void Run()
        {

            if (!Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        MoverParaCima();
                        break;


                    case ConsoleKey.DownArrow:
                        MoverParaBaixo();
                        break;

                    case ConsoleKey.RightArrow:

                       

                        break;

                    case ConsoleKey.LeftArrow:

                        //Corredor corredor = new Corredor(); 

                        break;


                    case ConsoleKey.F1:
                        CriarPasta();
                        break;


                    case ConsoleKey.Delete:
                        DeletarPastaArquivo();
                        break;

                    case ConsoleKey.Enter:
                        Entrar();
                        break;

                    case ConsoleKey.Escape:
                        Voltar();
                        break;

                    case ConsoleKey.F10:

                        Sys.Power.Shutdown();

                        break;

                }



            }



        }


        public void MoverParaCima()
        {
            tela.Up();

        }

        public void MoverParaBaixo()
        {
            tela.Down();

        }

        public void MoverParaDireita()
        {
            //tela.Right();

        }

        public void MoverParaEsquerda()
        {
            // tela.Left();

        }





        private void CriarPasta()
        {
            string resposta = Tela.MostrarMensagemUsuarioEAguardar("Digite o Nome Da Pasta: ");
            if (!string.IsNullOrEmpty(resposta))
            {
                Diretorio.Criar(resposta);
                tela.AtualizaTela();
            }


        }

        private void DeletarPastaArquivo()
        {
            bool ePasta = Sys.FileSystem.VFS.VFSManager.GetFileAttributes(Diretorio.CaminhoAtual + @"\" + ItensMenu.RetornaItemAtual) == FileAttributes.Directory;
            string resposta;

            if (ePasta)
            {
                resposta = Tela.MostrarMensagemUsuarioEAguardar($"Excluir a pasta {ItensMenu.RetornaItemAtual} selecionada (SIM ou (NAO): ");
            }
            else
            {
                resposta = Tela.MostrarMensagemUsuarioEAguardar($"Excluir o arquivo {ItensMenu.RetornaItemAtual} selecionada (SIM ou (NAO): ");
            }


            if (resposta.ToUpper() == "SIM")
            {
                if (ePasta)
                {
                    Diretorio.DeletarDiretorio();
                }
                else
                {
                    Arquivo.DeletarArquivo();
                }


                itens.AtualizaItens();
                tela = new Tela();
                tela.AtualizaTela();

            }


        }

        private void Entrar()
        {
            if (ItensMenu.RetornaTipoItemAtual == TipoDeArquivo.Pasta)
            {
                AbrirPasta();

            }
            else if (ItensMenu.RetornaTipoItemAtual == TipoDeArquivo.ArquivoDeTexto)
            {
                AbrirArquivo();

            }
            else
            {

                switch (ItensMenu.RetornaItemAtual)
                {
                    case "BLOCO DE NOTAS":
                        CriarArquivo();

                        break;

                    case "CALCULADORA":
                        Calcular();
                        break;

                     case "E-MAIL":
                  //  EnviarEmail();
                      break;

                    case "TERMINAL":

                        Terminal terminal = new Terminal();

                        break;

                    case "JOGO":

                      
                       
                        break;
                }


            }

        }
      

            private void Calcular()
        {
            string expressao = Tela.MostrarMensagemUsuarioEAguardar("Digite uma expressao: ");
            Tela.MostrarMensagemUsuario(Calculadora.RetornaCalculo(expressao));
        }


        private void AbrirPasta()
        {
            Diretorio.CaminhoAtual = Diretorio.CaminhoAtual + @"\" + ItensMenu.RetornaItemAtual;
            itens.AtualizaItens();
            tela = new Tela();
            tela.AtualizaTela();
        }
        private void AbrirArquivo()
        {
            Tela.PrepararAreaMensagem(Arquivo.Ler(Diretorio.CaminhoAtual + ItensMenu.RetornaItemAtual));
            Console.ReadKey();
            tela = new Tela();
            tela.AtualizaTela();

        }

        private void CriarArquivo()
        {
            string nomeArquivo = Tela.MostrarMensagemUsuarioEAguardar("Digite o Nome Do Arquivo: ");
            if (!string.IsNullOrEmpty(nomeArquivo))
            {
                Tela.PrepararAreaMensagem();
                string conteudo = Console.ReadLine().Trim();
                Tela.LimparAreaMensagem();

                string opcao = Tela.MostrarMensagemUsuarioEAguardar("Deseja Salvar o Arquivo (SIM) ou (NAO): ");

                if (opcao.ToUpper() == "SIM")
                {
                    Arquivo.Criar(nomeArquivo, conteudo);
                    tela.AtualizaTela();
                    Tela.MostrarMensagemUsuario("Arquivo Salvo Com Sucesso!");
                }

            }


        }




        private void Voltar()
        {
            if (Diretorio.CaminhoAtual != Constantes.CaminhoRaiz)
            {
                Diretorio.CaminhoAtual = Directory.GetParent(Diretorio.CaminhoAtual).FullName;
                itens.AtualizaItens();
                tela = new Tela();
                tela.AtualizaTela();

            }
        }

          private void EnviarEmail()
          {
              string destinatario = Tela.MostrarMensagemUsuarioEAguardar("Digite o e-mail do destinatario: ");
              string assunto = Tela.MostrarMensagemUsuarioEAguardar("Digite o assunto: ");


              if (!string.IsNullOrEmpty(destinatario)) 
              {
                  Tela.PrepararAreaMensagem();
                  string conteudo = Console.ReadLine().Trim();
                  Tela.LimparAreaMensagem();
                  string opcao = Tela.MostrarMensagemUsuarioEAguardar("Deseja enviar este e-mail (SIM) ou (NAO): ");


                  if (opcao.ToUpper() == "SIM")
                  {
                      E_mail.EnviarEmail(conteudo, assunto, destinatario);
                  }

              }

          }

  
        
    }
}

