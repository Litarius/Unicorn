using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Unicorn.Core.Client;
using Unicorn.Core.Server;
using Unicorn.Messages;

namespace Unicorn.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public static bool? IsServer;
        public static string Name;
        private readonly IServer _server;
        private readonly IClient _client;
        private ObservableCollection<string> _users;

        public MainViewModel(IServer server, IClient client)
        {
            _users = new ObservableCollection<string>();
            _server = server;
            _server.StatusChanged += ServerOnStatusChanged;
            _client = client;
            StartServer();
        }

        private void ServerOnStatusChanged()
        {
            Users.Clear();
            foreach (var user in _server.Users)
            {
                Users.Add(user);
            }
        }

        private void StartServer()
        {
            if (IsServer == true)
            {
                _server.Start(Name);
            }

            if (IsServer == false)
            {
                _client.Connect();
            }

        }

        public ObservableCollection<string> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                RaisePropertyChanged(() => Users);
            }
        }
    }
}