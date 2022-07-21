using Cosmos.System.FileSystem.Listing;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Sys = Cosmos.System;
using System.Drawing;
using SideralOS;
using IL2CPU.API.Attribs;
using Cosmos.System.Graphics;
using System.Resources;
using System.Runtime.InteropServices;
using System.Reflection;
using Cosmos.System.FileSystem;


namespace SideralOS
{
    class Arquivo
    {
        private static readonly ItensMenu itens = new ItensMenu();



        public static void Criar(string nomeArquivo, string conteudo)
        {
            string caminho = Diretorio.CaminhoAtual + @"\" + nomeArquivo;
            using (Escrever arquivo = new Escrever(caminho))
            {
                arquivo.CriarArquivo(conteudo);
            }

            itens.Add(nomeArquivo,TipoDeArquivo.ArquivoDeTexto);

        }

        public static string Ler(string caminhoArquivo)
        {
            string conteudo = "";
            using (Leitura arquivo = new Leitura(caminhoArquivo))
            {
                conteudo = arquivo.RetornaConteudo();
            }

            return null;
        }

        public static void DeletarArquivo(){

            string caminho = Diretorio.CaminhoAtual + @"\" + ItensMenu.RetornaItemAtual;

            try
            {
                VFSManager.DeleteFile(caminho);
                Tela.MostrarMensagemUsuario("Arquivo excluido com sucesso!");
                Console.ReadKey();
            }
            catch (Exception erro)
            {
                Tela.MostrarMensagemUsuario(erro.Message);

            }


        }

        public static void ListarArquivos()
        {
            foreach (DirectoryEntry item in VFSManager.GetDirectoryListing(Diretorio.CaminhoAtual))
                if (VFSManager.GetFileAttributes(item.mFullPath) != FileAttributes.Directory)
                    itens.Add(item.mName, TipoDeArquivo.ArquivoDeTexto);


        }



    }
}
