using System;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using Unicorn.Core.Messages;

namespace Unicorn.Core.Client
{
    public class Client : IClient
    {
        protected TcpClient TcpClient;

        public void Login(string userName)
        {
            if (TcpClient != null)
            {
                var message = new Message(MessageType.Login, userName, string.Empty).ToByteArray(); ;
                var networkStream = TcpClient.GetStream();
                networkStream.Write(message, 0, message.Length);
                var answer = new byte[1024];

                var responseData = String.Empty;
                var bytes = networkStream.Read(answer, 0, answer.Length);
                responseData = System.Text.Encoding.Unicode.GetString(answer, 0, bytes);

                networkStream.Close();
                TcpClient.Close();
            }
        }

        public void SendMessge(Message message)
        {
            if (TcpClient != null)
            {
                var networkStream = TcpClient.GetStream();
                networkStream.Write(message.Data, 0, message.Data.Length);
                var answer = new byte[1024];

                var responseData = String.Empty;
                var bytes = networkStream.Read(answer, 0, answer.Length);
                responseData = System.Text.Encoding.Unicode.GetString(answer, 0, bytes);

                networkStream.Close();
                TcpClient.Close();
            }
        }

        public void Connect()
        {
            try
            {
                const int port = 14222;
                var ipAddress = IPAddress.Parse("127.0.0.1");
                TcpClient = new TcpClient(ipAddress.ToString(), port);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
