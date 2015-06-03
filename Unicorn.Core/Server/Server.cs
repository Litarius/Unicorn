using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;
using Newtonsoft.Json;
using Unicorn.Core.Messages;

namespace Unicorn.Core.Server
{
    public class Server : IServer
    {
        private readonly TcpListener _server;
        private byte[] _buffer;
        private List<string> _users;
        public event Action<Message> StatusChanged;



        public Server()
        {
            const int port = 14222;
            var ipAddress = IPAddress.Parse("127.0.0.1");
            _server = new TcpListener(ipAddress, port);
            _buffer = new byte[2048];
            Users = new List<string>();
        }

        public async Task Start(string serverUserName)
        {
            await Task.Factory.StartNew(async () =>
            {
                try
                {
                    if (_server != null)
                    {
                        _server.Start();
                        NotifyStatusChanged(new Message(MessageType.SystemMessage, "Запуск сервера"));
                        NotifyStatusChanged(new Message(MessageType.Login, "", serverUserName));

                        while (true)
                        {
                            Thread.Sleep(1000);
                            var client = _server.AcceptTcpClient();
                            var stream = client.GetStream();

                            int i;

                            while ((i = await stream.ReadAsync(_buffer, 0, _buffer.Length)) != 0)
                            {
                                var data = System.Text.Encoding.UTF8.GetString(_buffer, 0, i);
                                var messageObject = JsonConvert.DeserializeObject<Message>(data);
                                NotifyStatusChanged(messageObject);

                                byte[] msg = System.Text.Encoding.UTF8.GetBytes(data);
                                stream.Write(msg, 0, msg.Length);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            );
        }

        private void NotifyStatusChanged(Message message)
        {
            if (StatusChanged != null)
            {
                StatusChanged(message);
            }
        }

        public List<string> Users
        {
            get { return _users; }
            set { _users = value; }
        }
    }
}
