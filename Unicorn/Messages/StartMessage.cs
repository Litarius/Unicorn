using Unicorn.Core.Server;

namespace Unicorn.Messages
{
    public class StartMessage
    {
        public StartMessage(bool isServer, string name)
        {
            IsServer = isServer;
            Name = name;
        }

        public bool IsServer { get; set; }

        public string Name { get; set; }
    }
}
