using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unicorn.Core.Messages;

namespace Unicorn.Core.Server
{
    public interface IServer
    {
        List<string> Users { get; set; }

        event Action<Message> StatusChanged;

        Task Start(string serverUserName);
    }
}
