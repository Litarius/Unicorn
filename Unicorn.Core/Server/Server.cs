using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Unicorn.Core.Server
{
    public class Server : IServer
    {
        private readonly TcpListener _server;
        private byte[] _buffer;

        public Server()
        {
            const int port = 14222;
            var ipAddress = IPAddress.Parse("127.0.0.1");
            _server = new TcpListener(ipAddress, port);
            _buffer = new byte[2048];
        }

        public async Task Start()
        {
            try
            {
                if (_server != null)
                {
                    _server.Start();

                    while (true)
                    {
                        Thread.Sleep(1000);
                        var client = _server.AcceptTcpClient();
                        var stream = client.GetStream();

                        int i;

                        while ((i = await stream.ReadAsync(_buffer, 0, _buffer.Length)) != 0)
                        {
                            var data = System.Text.Encoding.Unicode.GetString(_buffer, 0, i);
                            data = data.ToUpper();

                            byte[] msg = System.Text.Encoding.Unicode.GetBytes(data);
                            stream.Write(msg, 0, msg.Length);
                        }

                        client.Close();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (_server != null)
                {
                    _server.Stop();
                }
            }

        }
    }
}
