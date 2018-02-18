using System;
using System.Windows.Input;
using ProTrakr.Models;
using Prism.Commands;
using Prism.Navigation;

namespace ProTrakr.ViewModels
{
    public class ClientDetailPageViewModel: ViewModelBase
    {
        public ICommand SaveCommand => new DelegateCommand(OnSaveCommand);
        private Client _client;
        public Client Client
        {
            get => _client;
            set => SetProperty(ref _client, value);
        }

        public ClientDetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }

        public override void OnNavigatingTo(NavigationParameters parameters)
        {
            parameters.TryGetValue("Client", out Client client);
            Client = client;
            Title = Client?.Name;
        }

        private void OnSaveCommand()
        {
            NavigationService.GoBackAsync();
        }
    }
}
