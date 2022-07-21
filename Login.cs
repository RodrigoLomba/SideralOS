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

namespace SideralOS
{
    public class Login
    {
        public Login()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                         Aperte ENTER para continuar...");

            // Console.ReadLine();
            Console.ReadKey();
            Thread.Sleep(900);


            Console.Clear();
            //////////////////////////////////////////////////////////////

            Console.WriteLine("");
            Console.WriteLine("");

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
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                 Seja Bem-Vindo Rodrigo!                          ");
                Console.WriteLine("");
                Console.WriteLine("");
                
                Thread.Sleep(1000);
                Console.Clear();


                Tela tela = new Tela(); 

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("                                 Accesso Negado!                                   ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");
                Console.WriteLine("");


                Thread.Sleep(1000);
                Console.Clear();


            }



       


       }
    
    }
}
