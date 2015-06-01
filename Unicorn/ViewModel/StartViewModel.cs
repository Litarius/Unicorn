using System.Collections.Generic;
using System.Net;
using GalaSoft.MvvmLight;

namespace Unicorn.ViewModel
{
    public class StartViewModel : ViewModelBase
    {
        private bool _isServer;
        private bool _isClient;
        private string _userName;
        private string _serverAdress;

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
                RaisePropertyChanged(()=>CanStart);
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

    }
}
