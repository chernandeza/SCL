using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    [Serializable]
    public class Message
    {
        private String _msg;

        public String Content
        {
            get { return _msg; }
            set { _msg = value; }
        }

        private Level _lvl;

        public Level Importance
        {   
            get { return _lvl; }
            set { _lvl = value; }
        }

        private String _id;

        public String From
        {
            get { return _id; }
            set { _id = value; }
        }        

        public Message()
        {
            this._lvl = Level.None;
            this._msg = "";
            this._id = "";
        }
    }

    [Serializable]
    public enum Level : byte
    {
        None,
        Low,
        Warning,
        Error,
        Critical,
        Debug
    }

    /// <summary>
    /// Defines the type of interactions between provider and server
    /// </summary>
    [Serializable]    
    public enum ControlMessage : byte
    {
        CM_None,
        CM_Hello,
        CM_OK,
        CM_ACK,
        CM_Error,
        CM_Message
    };
}
