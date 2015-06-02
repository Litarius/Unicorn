using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Unicorn.Core.Server
{
    public interface IServer
    {
        List<string> Users { get; set; }

        event Action StatusChanged;

        Task Start(string serverUserName);
    }
}
