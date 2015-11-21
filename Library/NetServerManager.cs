using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace Library
{
    /// <summary>
    /// Esta clase representa la conexión con el cliente. Por cada cliente conectado, el servidor instancia un objeto de esta clase.
    /// </summary>
    public class NetServerManager
    {
        private IPAddress ip = IPAddress.Parse("127.0.0.1");    //IP de "localhost"
        private int port = 10830;       //Puerto para escuchar por conexiones
        public bool running;     //Indica si el servidor está escuchando por conexiones o no
        private TcpListener listener;     //TCPListener para escuchar por conexiones
        public static DataBaseController db;            // Enlace a la base de datos

        public event EventHandler ClientConnected; // Evento se dispara cuando se conecta un cliente
        public event MessageReceivedEventHandler MessageReceived; //Evento se dispara cuando se recibe un mensaje
        public event EventHandler ClientDisconnected; //Evento se dispara cuando se desconecta un cliente.

        /*Estos métodos validan que la suscripción a los eventos no esté vacía. Si está vacía, no lanza el evento de forma innecesaria*/
        virtual protected void OnClientDisconnected()
        {
            if (ClientDisconnected != null)
                ClientDisconnected(this, EventArgs.Empty);
        }

        virtual protected void OnClientConnected()
        {
            if (ClientConnected != null)
                ClientConnected(this, EventArgs.Empty);
        }

        virtual protected void OnMessageReceived(MessageEventArgs e)
        {
            if (MessageReceived != null)
                MessageReceived(this, e);
        }

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        /// <param name="mSc">Información del servidor con el que se conecta el cliente proveedor</param>
        /// <param name="tcpC">Canal de comunicación para hablar con el servidor</param>
        public NetServerManager()
        {
            this.running = false;
            db = new DataBaseController();
        }

        public void Initialize()
        {
            listener = new TcpListener(ip, port);
            listener.Start();
            this.running = true;
            Listen();
        }

        void Listen()
        {
            while (running)
            {
                TcpClient tcpClient = listener.AcceptTcpClient();  // Acepta una conexión entrante
                //Crear una nueva tarea para cada uno de los clientes.
                new Task(() => ConnectionSetup(tcpClient)).Start();
            }
        }

        private void ConnectionSetup(TcpClient tcpC)
        {
            TcpClient commChannel;                   // Canal de comunicación hacia el servidor
            NetworkStream netStream;                 // Stream del canal de respuesta para enviar datos hacia el servidor.
            BinaryReader netDataReader;              // Utilizado para leer datos del canal de comunicación
            BinaryWriter netDataWriter;              // Utilizado para escribir datos en el canal de comunicación
            commChannel = tcpC;

            try
            {
                netStream = commChannel.GetStream(); //Obtenemos el canal de comunicación
                netDataReader = new BinaryReader(netStream, Encoding.UTF8);
                netDataWriter = new BinaryWriter(netStream, Encoding.UTF8);

                //Enviamos un "HELLO" al cliente y esperamos respuesta
                netDataWriter.Write((Byte)(ControlMessage.CM_Hello));
                netDataWriter.Flush();

                //Esperamos un "HELLO" proveniente del cliente
                ControlMessage clientMsg = (ControlMessage)Enum.Parse(typeof(ControlMessage), netDataReader.ReadByte().ToString());
                if (clientMsg == ControlMessage.CM_Hello)
                {
                    // Se recibió un mensaje de "hello". El cliente responde adecuadamente. Se inicia la interacción con el cliente.
                    // Enviamos un mensaje de Acknowledge y luego iniciamos la interacción.
                    netDataWriter.Write((Byte)(ControlMessage.CM_ACK));
                    netDataWriter.Flush();
                    OnClientConnected();
                    InteractWithClient(ref commChannel, ref netDataReader, ref netDataWriter);  // Listen to client in loop.
                }
                else
                {
                    throw new Exception("Server Unresponsive");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ConnectionSetup" + Environment.NewLine + ex.Message);
            }
            finally
            {
                OnClientDisconnected();
                //CloseConn();
            }
        }

        private void InteractWithClient(ref TcpClient commChannel, ref BinaryReader netDataReader, ref BinaryWriter netDataWriter)  // Receive all incoming packets.
        {
            try
            {
                while (commChannel.Client.Connected)  // While we are connected.
                {
                    ControlMessage ctrlMsg = (ControlMessage)Enum.Parse(typeof(ControlMessage), netDataReader.ReadByte().ToString());  
                    /*La instrucción anterior parsea el contenido de un mensaje de control que el cliente envía 
                     * previo a colocar cualquier mensaje en el medio de red. 
                     * La interacción es básicamente siempre así: 
                     *      1. El cliente envía un mensaje de control.
                     *      2. Si el mensaje de control es de tipo CM_Message, el cliente envía:
                     *          2.1 El tamaño del mensaje.
                     *          2.2 Los datos del mensaje serializados.
                     *      3. El servidor parsea el mensaje de control y el mensaje.
                     *      4. El servidor envía una confirmación al cliente indicando que se recibió el mensaje correctamente.
                     *      5. El servidor genera un evento que contiene el mensaje y que puede ser utilizado por la GUI para presentarlo al usuario.
                     */ 

                    switch (ctrlMsg)
                    {
                        case ControlMessage.CM_Message:
                            /*
                             * El cliente va a enviar un mensaje. Debemos deserializar el contenido para luego pasarlo a la GUI.
                             */
                            Message newMsg = new Message();
                            // Leemos el tamaño del mensaje
                            int sizeOfMsg = netDataReader.ReadInt32();
                            newMsg = (Message)ObjSerializer.ByteArrayToObject(netDataReader.ReadBytes(sizeOfMsg));
                            lock (db)
                            {
                                if (db.AddNewMessage(newMsg))
                                {
                                    netDataWriter.Write((Byte)ControlMessage.CM_OK);
                                    netDataWriter.Flush(); //Mensaje almacenado en la BD con éxito
                                    MessageEventArgs infoMsg = new MessageEventArgs(newMsg, DateTime.Now);
                                    OnMessageReceived(infoMsg); //Se dispara el evento y agregamos la información del mensaje recibido
                                    // Esto para que la GUI pueda tener acceso al mensaje.
                                }
                                else
                                {
                                    netDataWriter.Write((Byte)ControlMessage.CM_Error);
                                    netDataWriter.Flush(); //Problemas almacenando mensaje
                                }
                            }
                            break;
                        case ControlMessage.CM_GetMessages:
                            Level msgLevel = (Level)Enum.Parse(typeof(Level), netDataReader.ReadByte().ToString());
                            Dictionary<int, Message> msgType = db.GetAllMessagesByType(msgLevel);
                            if (msgType.ContainsKey(-1))
                            {
                                netDataWriter.Write((Byte)ControlMessage.CM_NoMessages);
                                netDataWriter.Flush(); //No hay mensajes 
                            }
                            else 
                            {
                                if (msgType.Count > 0)
                                {
                                    netDataWriter.Write((Byte)ControlMessage.CM_OK);
                                    netDataWriter.Flush(); //Hay mensajes
                                    netDataWriter.Write(ObjSerializer.ObjectToByteArray(msgType).Length);
                                    netDataWriter.Write(ObjSerializer.ObjectToByteArray(msgType));
                                    netDataWriter.Flush();
                                }
                                else
                                {
                                    netDataWriter.Write((Byte)ControlMessage.CM_Error);
                                    netDataWriter.Flush(); //Mensaje de error al cliente
                                }
                            }
                            /*
                             * Si existiesen más interacciones entre el cliente y el servidor, se deberían agregar más 
                             * cases a este switch según mensajes de control existan y que se envíen desde el cliente.
                             */
                            break;
                        default:
                            break;
                    }
                }
            }
            catch
            {
                netDataWriter.Write((Byte)ControlMessage.CM_Error);
                netDataWriter.Flush();
            }
        }

        /*private void CloseConn() // Close connection.
        {
            try
            {
                netDataReader.Close();
                netDataWriter.Close();
                netStream.Close();
                commChannel.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in CloseConn" + Environment.NewLine + ex.Message);
            }
        }*/

        /*
        * Garbage Collection Dispose Methods implemented as Programming Best Practices.
        */
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose managed resources
                //mainServer.Dispose();
                listener.Stop();
                //commChannel.Close();
                //netStream.Dispose();
                //netDataReader.Dispose();
                //netDataWriter.Dispose();
                db.Dispose();
            }
            // free native resources
        }

        /// <summary>
        /// Disposes the DBConnector object
        /// </summary>  
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


    }
}
