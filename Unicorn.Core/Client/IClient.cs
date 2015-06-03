using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicorn.Core.Messages;

namespace Unicorn.Core.Client
{
    public interface IClient
    {
        void SendMessge(Message message);

        void Connect();
    }
}
