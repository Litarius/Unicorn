using System.Security.Cryptography.X509Certificates;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Unicorn.Core.Client;
using Unicorn.Core.Server;

namespace Unicorn.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IServer _server;
        private IClient _client;

        public MainViewModel(IServer server, IClient client)
        {
            StartServerCommand = new RelayCommand(StartServer);

            _server = server;
            _client = client;

        }

        private void StartServer()
        {
            _server.Start();
        }

        public ICommand StartServerCommand { get; set; }
    }
}