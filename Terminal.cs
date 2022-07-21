using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
using SideralOS;
using System.Threading;
using Cosmos.System.Graphics;
using System.Drawing;
using IL2CPU.API.Attribs;
using System.IO;
using Cosmos.System.Network.Config;
using Cosmos.Core.IOGroup;
using Cosmos.HAL;
using Cosmos.System.Network.IPv4;
using Cosmos.System.Network.IPv4.TCP;
using Cosmos.System.Network.IPv4.UDP.DHCP;
using Cosmos.System.Network;
using static SideralOS.Kernel;
using RTC = Cosmos.HAL.RTC;

namespace SideralOS
{




public class Terminal
    {






private ItensMenu itensMenu;
        private Tela tela;



        public static int ClockFormatSettings = 1;
        public static bool Clock24HourSetting = true;
        public static uint sensitivity = 2;
       
        


        public Terminal()
        {


            Console.CursorVisible = true;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            int ram = 512;
            int cpu = 500;
            int psu = 120;
            string net = "";
            string hdd = "";
            static int Hour() { return RTC.Hour; }

            static int Minute() { return RTC.Minute; }
            static int Year() { return RTC.Year; }

            static int Month() { return RTC.Month; }

            static int DayOfMonth() { return RTC.DayOfTheMonth; }

            static int DayOfWeek() { return RTC.DayOfTheWeek; }

            Console.WriteLine("SideralOS Versao 0.0.0.1                             ");
            Console.WriteLine("Cedup Timbo - 2022");
            Console.WriteLine();
            Console.Write(@"C:\Usuario>");





            while (true)
            {
                string command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "help":
                        Console.WriteLine("Escolha um dos comandos a baixo: ");
                        Console.WriteLine();
                        Console.WriteLine("HELP            Comandos disponiveis.");
                        Console.WriteLine("ABOUT           Informacoes sobre o sistema operacional.");
                        Console.WriteLine("INFO CPU        Informacoes sobre o CPU");
                        Console.WriteLine("CLS             Limpa o Console.");
                        Console.WriteLine("DATA            Exibe Data atual.");
                        Console.WriteLine("REBOOT          Reinicia o sistema.");
                        Console.WriteLine("IPCONFIG        Apresenta o ip do dispositivo.");
                        Console.WriteLine("TIME            Apresenta o horario.");
                        Console.WriteLine("SHUTDOWN        Desliga o sistema.");
                        Console.WriteLine("INFO MEMORIA    informacoes sobre a memoria.");
                        
                        Console.WriteLine();



                        Console.Write(@"C:\Usuario>");
                        Console.CursorVisible = true;
                        break;

                    case "cls":
                        
                        Console.Clear();
                        Console.WriteLine("SideralOS Versao 0.0.0.1                             ");
                        Console.WriteLine("<c> 2022 Sideral S/A");
                        Console.WriteLine();
                        Console.Write(@"C:\Usuario>");
                        break;

                    case "qrcosmos /site":

                      //  Imagens imagens = new Imagens();

                        Console.Write(@"C:\Usuario>");

                        break;

                    case "qrcosmos /gh":

                        
                        Console.Write(@"C:\Usuario>");

                        break;

                    case "data":

                        Console.Write("DIA " + DayOfMonth() + " DE " + "JULHO" + " DE " + "20" + Year());
                        Console.WriteLine();
                        Console.Write(@"C:\Usuario>");

                        break;


                    case "about":
                        Console.WriteLine("SideralOS Version 0.0.0.1");
                        Console.WriteLine("SideralOS Version 0.0.0.1");
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.Blue;

                        Console.Write("                                      Sideral");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("OS");

                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("                              SideralOS Versao 0.0.0.1                                   ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("                         Atualmente em execucao ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("ATIVO");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(" Modo                             ");
                        Console.WriteLine("                              <c> 2022 Rodrigo Ventura                            ");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("SideralOS Versao 0.0.0.1                             ");
                        Console.WriteLine("<c> 2022 Sideral S/A. Todos direitos reservados");
                        Console.WriteLine("");
                        Console.WriteLine("Especificacoes do sistema");
                        Console.WriteLine("RAM: " + ram.ToString() + "MB");
                        Console.WriteLine("CPU: " + cpu.ToString() + "MHz");
                        Console.WriteLine("Network Name: " + net);
                        Console.WriteLine("HDD: " + hdd);
                        Console.WriteLine("Psu Voltage: " + psu + " Volts");

                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("SideralOS Version 0.0.0.1                             ");
                        Console.WriteLine("<c> 2022 Sideral S/A. Todos direitos reservados");
                        Console.WriteLine();
                        Console.Write(@"C:\Usuario>");

                        break;

                        case "shutdown":

                        Sys.Power.Shutdown();

                        break;

                        case "reboot":

                        Sys.Power.Reboot();

                        break;

                        case "jogo":

                      //  Imagens imagens1 = new Imagens();
                       // imagens1.INIT();

                        break;

                        case "info /cpu":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("...");
                        Thread.Sleep(800);
                        Console.WriteLine("...");
                        Thread.Sleep(700);
                        Console.WriteLine("...");
                        Thread.Sleep(600);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[========================= INFORMACOES DO PROCESSADOR =========================]");
                        Console.WriteLine("");                                       

                        try
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("CPU: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Cosmos.Core.CPU.GetCPUBrandString().ToString());
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine("FABRICANTE CPU: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(Cosmos.Core.CPU.GetCPUVendorName());

                            try
                            {
                                var cpu_speed = Cosmos.Core.CPU.GetCPUCycleSpeed();
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                Console.WriteLine("FREQUENCIA CPU: ");
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(cpu_speed + " MHz");
                            }
                            catch
                            {
                                try
                                {
                                    var cpu_speed = Cosmos.Core.CPU.EstimateCPUSpeedFromName(Cosmos.Core.CPU.GetCPUBrandString());
                                    Console.WriteLine("Velocidade de frequencia do CPU: " + cpu_speed + " MHz");
                                }
                                catch
                                {
                                    Console.WriteLine("Velocidade de frequencia do CPU: [NAO IDENTIFICADO]");
                                }
                            }
                            //Console.WriteLine("Total installed memory: " + Cosmos.Core.CPU.GetAmountOfRAM() + " MB");
                            //Console.WriteLine("Used memory: " + (Cosmos.Core.CPU.GetAmountOfRAM() - Cosmos.Core.GCImplementation.GetAvailableRAM()) + " MB");
                            //Console.WriteLine("Available memory: " + Cosmos.Core.GCImplementation.GetAvailableRAM() + " MB");
                            try
                            {
                                if (Cosmos.HAL.NetworkDevice.Devices.Count < 1)
                                {
                                   // Console.WriteLine("IPv4 Address: [No usable network devices!]");
                                }
                                else
                                {
                                  //  var ip = NetworkConfiguration.CurrentNetworkConfig.IPConfig.IPAddress;
                                   // Console.WriteLine("IPv4 Address: " + ip);
                                }
                            }
                            catch
                            {

                            }
                            Console.WriteLine();
                        }
                        catch
                        {

                        }

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(@"C:\Usuario>");
                        break;

                            case "ipconfig":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(NetworkConfiguration.CurrentAddress.ToString());
                        
                        break;

                    case "time":

                       Console.Write( Hour() + ":" + Minute());
                        Console.WriteLine();
                        Console.Write(@"C:\Usuario>");

                        break;

                    case "info /memoria":

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("...");
                        Thread.Sleep(800);
                        Console.WriteLine("...");
                        Thread.Sleep(700);
                        Console.WriteLine("...");
                        Thread.Sleep(600);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("[========================= INFORMACOES DA MEMORIA =========================]");
                        Console.WriteLine("");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Total de memoria instalada: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Cosmos.Core.CPU.GetAmountOfRAM() + " MB");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Memoria utilizada: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine((Cosmos.Core.CPU.GetAmountOfRAM() - Cosmos.Core.GCImplementation.GetAvailableRAM()) + " MB");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Memoria disponivel: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Cosmos.Core.GCImplementation.GetAvailableRAM() + " MB");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(@"C:\Usuario>");

                        break;



                    case "voltar":

                        Kernel kernel = new Kernel();
                        


                        break;

                    

                }



               
            }
        }


    }
}
