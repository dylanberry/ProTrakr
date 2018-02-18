using System;
using System.Collections.Generic;
using System.Windows.Input;
using ProTrakr.Models;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;

namespace ProTrakr.ViewModels
{
    public class ClientListPageViewModel : ViewModelBase
    {
        public ICommand NewCommand => new DelegateCommand<Client>(OnNewCommand);
        public ICommand DetailCommand => new DelegateCommand<Client>(OnNewCommand);
        public IList<Client> ClientList { get; set; }

        public ClientListPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Clients";

            var bsiLabs = new Client
            {
                Name = "BSI Labs",
                Location = "Toronto, Ontario, Canada"
            };
            bsiLabs.Projects.Add(new Project { Name = "ProTrakr", StartDate = DateTime.Today });

            var microsoft = new Client
            {
                Name = "Microsoft",
                Location = "Redmond, Washington, USA"
            };
            microsoft.Projects.Add(new Project { Name = "Xamarin", StartDate = DateTime.Today });
            microsoft.Projects.Add(new Project { Name = "Visual Studio", StartDate = DateTime.Today });

            ClientList = new List<Client>
            {
                bsiLabs,
                microsoft
            };
        }

        public void OnNewCommand(Client item)
        {
            NavigationService.NavigateAsync("ClientDetailPage", new NavigationParameters { { "Client", item } });
        }
    }
}
