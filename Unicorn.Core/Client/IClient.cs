using Unicorn.Core.Messages;

namespace Unicorn.Core.Client
{
    public interface IClient
    {
        void SendMessge(Message message);

        void Login(string userName);

        void Connect();
    }
}
