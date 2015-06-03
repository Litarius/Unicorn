using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Threading;
using GalaSoft.MvvmLight;
using Unicorn.Core.Client;
using Unicorn.Core.Messages;
using Unicorn.Core.Server;
using Unicorn.View;

namespace Unicorn.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public static bool? IsServer;
        public static string Name;
        private readonly IServer _server;
        private readonly IClient _client;
        private ObservableCollection<string> _users;
        private string _chatText;

        public MainViewModel(IServer server, IClient client)
        {
            _users = new ObservableCollection<string>();
            _server = server;
            _server.StatusChanged += ServerOnStatusChanged;
            _client = client;
            _chatText = string.Empty;
            StartServer();
        }

        private void ServerOnStatusChanged(Message message)
        {
            Dispatcher.CurrentDispatcher.Invoke(() =>
            {
                switch (message.Type)
                {
                    case MessageType.Login:
                        if (!_users.Contains(message.UserName))
                        {
                            _users.Add(message.UserName);
                            RaisePropertyChanged(() => Users);
                            ChatText += string.Format("[{0}] Пользователь {1} вошел в чат \n", DateTime.Now, message.UserName);
                        }

                        break;
                    case MessageType.SystemMessage:
                        ChatText += string.Format("[{0}] {1}\n", DateTime.Now, message.StringData);
                        break;
                }
            });
        }

        private void StartServer()
        {
            try
            {
                if (IsServer == true)
                {
                    _server.Start(Name);
                }

                if (IsServer == false)
                {
                    _client.Connect();
                    _client.Login(Name);
                }
            }
            catch (Exception e)
            {
                DialogBox dialogBox = new DialogBox("Ошибка", e.Message);
                dialogBox.ShowDialog();
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

        public string ChatText
        {
            get { return _chatText; }
            set
            {
                _chatText = value;
                RaisePropertyChanged(() => ChatText);
            }
        }
    }
}