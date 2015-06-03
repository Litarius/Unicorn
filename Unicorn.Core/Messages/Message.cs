using System.Text;
using Newtonsoft.Json;

namespace Unicorn.Core.Messages
{
    public class Message
    {
        public Message(MessageType type, string message, string userName = "", byte[] file = null)
        {
            Type = type;
            UserName = userName;
            StringData = message;
            Data = file;
        }

        public MessageType Type { get; private set; }

        public string StringData { get; private set; }

        public byte[] Data { get; private set; }

        public string UserName { get; private set; }

        public byte[] ToByteArray()
        {
            var jsonString = JsonConvert.SerializeObject(this);
            var byteArray = Encoding.UTF8.GetBytes(jsonString);
            return byteArray;
        }
    }
}
