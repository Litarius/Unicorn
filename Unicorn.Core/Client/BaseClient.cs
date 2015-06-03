using System;
using System.Net;
using System.Net.Sockets;
using Unicorn.Core.Messages;

namespace Unicorn.Core.Client
{
    public class BaseClient : IClient
    {
        protected TcpClient Client;

        public void SendMessge(Message message)
        {
            if (Client != null)
            {
                var networkStream = Client.GetStream();
                networkStream.Write(message.Data, 0, message.Data.Length);
                var answer = new byte[1024];

                var responseData = String.Empty;
                var bytes = networkStream.Read(answer, 0, answer.Length);
                responseData = System.Text.Encoding.ASCII.GetString(answer, 0, bytes);

                networkStream.Close();
                Client.Close();
            }
        }

        public void Connect()
        {
            try
            {
                const int port = 14222;
                var ipAddress = IPAddress.Parse("127.0.0.1");
                Client = new TcpClient(ipAddress.ToString(), port);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
