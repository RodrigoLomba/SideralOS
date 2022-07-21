using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cosmos.System.FileSystem.Listing;
using System.IO;

namespace SideralOS
{
    class Diretorio
    {
        public static string CaminhoAtual { get; set; } = Constantes.CaminhoRaiz;


        private static readonly ItensMenu itens = new ItensMenu();


        public static void CriarSistemaArquivo()
        {
            CosmosVFS vfs = new CosmosVFS();
            VFSManager.RegisterVFS(vfs);

            if(!VFSManager.DirectoryExists(Constantes.CaminhoRaiz))
            {
                VFSManager.CreateDirectory(Constantes.CaminhoRaiz);
            }

        }
        public static void Criar(string nomePasta)
        {
            string caminhoPasta = CaminhoAtual + @"\" + nomePasta;

            try
            {
                if (VFSManager.DirectoryExists(caminhoPasta))
                {
                    Tela.MostrarMensagemUsuario("Esta pasta já existe!");

                }else
                {
                    VFSManager.CreateDirectory(caminhoPasta);
                 itens.Add(caminhoPasta, TipoDeArquivo.Pasta);

                    Tela.MostrarMensagemUsuario("Pasta criada com sucesso!");
                    Console.ReadKey();
                }

            }
            catch (Exception erro)
            {
                Tela.MostrarMensagemUsuario(erro.Message);
            }

        }
        public static void DeletarDiretorio()
        {
            string caminho = CaminhoAtual + @"\" + ItensMenu.RetornaItemAtual;

            try
            {
                VFSManager.DeleteDirectory(caminho, true);
                Tela.MostrarMensagemUsuario("Pasta excluida com sucesso!");
                Console.ReadKey();
            }
            catch (Exception erro)
            {               
                Tela.MostrarMensagemUsuario(erro.Message);

            }



        }
        public static void ListarDiretorio()
        {
            foreach (DirectoryEntry item in VFSManager.GetDirectoryListing(CaminhoAtual))
            if(VFSManager.GetFileAttributes(item.mFullPath) == FileAttributes.Directory)
                    itens.Add(item.mName, TipoDeArquivo.Pasta);

        }

    }
}
