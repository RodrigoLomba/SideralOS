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
    class Escrever : IDisposable
    {
        private readonly FileStream fs;

        public Escrever(string caminhoArquivo)
        {
            fs = (FileStream)VFSManager.GetFileStream(caminhoArquivo);

        }

        public void CriarArquivo(string conteudo) {
            if (fs.CanWrite)
            {
                byte[] dados = Encoding.ASCII.GetBytes(conteudo);   
                fs.Write(dados, 0, dados.Length);
            }
        
        }

        public void Fechar()
        {
            fs.Close();
            
        }


        public void Dispose()
        {
            fs.Close();
            fs.Dispose();
            
        }
    }
}
