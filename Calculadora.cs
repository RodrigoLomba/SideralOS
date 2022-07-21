using System;
using System.Collections.Generic;
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
using System.IO;

namespace SideralOS
{
    static class Calculadora
    {
    
        public static string RetornaCalculo(string expressao)
        {
            if (ExpressaoValidada(expressao))
            {
                return expressao + " = " + Calcular(expressao);

            }
            else
            {
                return "Expressao invalida!";
            }


        }

        private static bool ExpressaoValidada(string expressao)
        {
            if (expressao.Split('-', '+', '*', '/').Length != 2)
            {
                return false;
            }

            return true;
        }
        public static string Calcular(string expressao)
        {
            try
            {
                int n1 = int.Parse(expressao.Split('-', '+', '*', '/')[0].Trim());
                int n2 = int.Parse(expressao.Split('-', '+', '*', '/')[1].Trim());


                if (expressao.Contains("-"))
                {
                    return Convert.ToString(n1 - n2);
                }else if (expressao.Contains("+"))
                {
                    return Convert.ToString(n1 + n2);
                }else if (expressao.Contains("*"))
                {
                    return Convert.ToString(n1 * n2);
                }else 
                {
                    return Convert.ToString(n1 / n2);
                }



            }
            catch (Exception erro)
            {
                Tela.MostrarMensagemUsuario(erro.Message);
                return null;

            }


        }




    }
}
