using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicorn.Core.Messages
{
    public class Message 
    {
        public Message(MessageType type, string message)
        {
            Type = type;
            Data = Encoding.Unicode.GetBytes(message);
        }

        public MessageType Type { get; private set; }

        public byte[] Data { get; private set; }
    }
}
