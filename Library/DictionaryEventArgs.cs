using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class DictionaryEventArgs : EventArgs
    {
        private Dictionary<int, Message> _msgs;

        public Dictionary<int, Message> Messages
        {
            get { return _msgs; }
            set { _msgs = value; }
        }
    }
    public delegate void DictReceivedEventHandler(object sender, DictionaryEventArgs e);
}
