using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Esta clase se envía como parámetro en el evento cuando arriba un mensaje al cliente. Contiene la fecha/hora y el mensaje recibido.
    /// </summary>
    public class MessageEventArgs : EventArgs
    {
        private DateTime _dt;

        public DateTime DT
        {
            get { return _dt; }
            set { _dt = value; }
        }

        private Message _m;

        public Message M
        {
            get { return _m; }
            set { _m = value; }
        }

        public MessageEventArgs(Message pe, DateTime dt)
        {
            this._m = pe;
            this._dt = dt;
        }
    }
    public delegate void MessageReceivedEventHandler(object sender, MessageEventArgs e);
}
