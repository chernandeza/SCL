using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            NetServerManager mainServer = new NetServerManager();

            //Suscripción a los eventos del objeto NetServerManager
            mainServer.MessageReceived += mainServer_MessageReceived;
            mainServer.ClientConnected += mainServer_ClientConnected;
            mainServer.ClientDisconnected += mainServer_ClientDisconnected;
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Servidor Iniciado...");
            mainServer.Initialize(); //Llamado al método inicializar del objeto NetServerManager
        }

        static void mainServer_ClientDisconnected(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cliente desconectado del servidor!");
        }

        static void mainServer_ClientConnected(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Cliente conectado al servidor!");
        }

        static void mainServer_MessageReceived(object sender, MessageEventArgs e)
        {
            //Cambiar de color la consola dependiendo de la importancia del mensaje
            switch (e.M.Importance)
            {
                case Level.Critical:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString());
                    break;
                case Level.Debug:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString());
                    break;
                case Level.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString());
                    break;
                case Level.Low:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString());
                    break;
                case Level.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString());
                    break;
                case Level.None:
                default:
                    break;
            }
            Console.WriteLine("Mensaje recibido: " + "Hora: " + e.DT.ToShortDateString() + " --> " + e.M.Content + " Criticidad: " + e.M.Importance.ToString() );
        }
    }
}
