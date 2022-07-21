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


namespace SideralOS
{
    class Leitura : IDisposable
    {
        private readonly FileStream fs;

        public Leitura(string caminhoArquivo)
        {
            fs = (FileStream)VFSManager.GetFileStream(caminhoArquivo);


        }


        public string RetornaConteudo()
        {
            try { 
            byte[] dados = new byte[fs.Length];
                fs.Read(dados, 0, dados.Length);

                return Encoding.ASCII.GetString(dados);


            }catch(FileLoadException erro)
            {
                Tela.MostrarMensagemUsuario(erro.Message);

                return null;

            }


        }



        public void Fechar()
        {
            fs.Close();

        }

        public void Dispose()
        {
            fs.Dispose();
            fs.Close();
        }
    }
}
