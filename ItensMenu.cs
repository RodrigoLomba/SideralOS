using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideralOS
{
    class ItensMenu
    {
        public static int PosicaoItemAtual { get; set; } = 0;

        public Posição posição { get; set; }

        public string Nome { get; private set; }

        public TipoDeArquivo TipoDeArquivo { get; private set; }

        public static string RetornaItemAtual
        {
            get
            {
                return menu[PosicaoItemAtual].Nome;

            }


        }
        public static TipoDeArquivo RetornaTipoItemAtual
        {
            get
            {
                return menu[PosicaoItemAtual].TipoDeArquivo;
            }


        }

        private static List<ItensMenu> menu;


        public ItensMenu()
        {
            if(menu == null)
            {
                menu = new List<ItensMenu>();
                AddItensFixos();
                Arquivo.ListarArquivos();
                Diretorio.ListarDiretorio();
            }
        }

        private ItensMenu(Posição posição, string nome, TipoDeArquivo tipoDeArquivo)
        {
            this.posição = posição;
            Nome = nome;
            TipoDeArquivo = tipoDeArquivo;
        }

        public void Add(string nome, TipoDeArquivo tipoDeArquivo )
        {
            Posição posicaoItemAtual = Posição.RetornaPosicao();

            menu.Add(new ItensMenu(posicaoItemAtual, nome, tipoDeArquivo));
            Posição.IncrementaY();
        }

        public void AtualizaItens()
        {
            Posição.ResetaPosicaoAtual();
            menu = new List<ItensMenu>();
            PosicaoItemAtual = 0;
            AddItensFixos();
            Arquivo.ListarArquivos();
            Diretorio.ListarDiretorio();
        }

        public List<ItensMenu> RetornaItens()
        {
            return menu;
        }


        private string RetornaNomeComBorda(string nomeItem)
        {
            int metadeEspaco = Constantes.LarguraItem / 2;
            int metadeNome = nomeItem.Length / 2;
            int espacoAEsquerda = metadeEspaco - metadeNome;

            nomeItem = new String(' ', espacoAEsquerda) + nomeItem;
            nomeItem = nomeItem.PadRight(Constantes.LarguraItem, ' ');

            return nomeItem;
        }


        public void AddItensFixos()
        {
            
            Add("BLOCO DE NOTAS", TipoDeArquivo.ArquivoDeSistema);
            Add("TERMINAL", TipoDeArquivo.ArquivoDeSistema);
            Add("CALCULADORA", TipoDeArquivo.ArquivoDeSistema);
            Add("E-MAIL", TipoDeArquivo.ArquivoDeSistema);
            Add("JOGO", TipoDeArquivo.ArquivoDeSistema);
            
        }



    }
}
