using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Unicorn.Messages;

namespace Unicorn.ViewModel
{
    public class StartViewModel : ViewModelBase
    {
        private bool _isServer;
        private bool _isClient;
        private string _userName;
        private string _serverAdress;
        private ICommand _startCommand;

        public StartViewModel()
        {
            _startCommand = new RelayCommand(StartChat);
        }

        private void StartChat()
        {
            MainViewModel.IsServer = _isServer;
            MainViewModel.Name = _userName;
            Messenger.Default.Send(new StartMessage(_isServer, _userName));
        }

        public bool IsServer
        {
            get { return _isServer; }
            set
            {
                _isServer = value;
                RaisePropertyChanged(() => CanStart);
                RaisePropertyChanged(() => IsServer);
            }
        }

        public bool IsClient
        {
            get { return _isClient; }
            set
            {
                _isClient = value;
                RaisePropertyChanged(() => CanStart);
                RaisePropertyChanged(() => IsClient);
            }
        }

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => CanStart);
                RaisePropertyChanged(() => UserName);
            }
        }

        public string ServerAdress
        {
            get { return _serverAdress; }
            set
            {
                _serverAdress = value;
                RaisePropertyChanged(() => CanStart);
                RaisePropertyChanged(() => ServerAdress);
            }
        }

        public bool CanStart
        {
            get
            {
                return (IsClient && !string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(ServerAdress)) ||
                       (IsServer && !string.IsNullOrEmpty(UserName));
            }
        }

        public ICommand StartCommand
        {
            get { return _startCommand; }
            set
            {
                _startCommand = value;
                RaisePropertyChanged(() => StartCommand);
            }
        }
    }
}
