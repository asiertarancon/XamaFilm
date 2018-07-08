using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class SettingsViewModel : Base.ViewModelBase
    {
        public SettingsViewModel()
        {

        }

        public override async Task InitializeAsync(object navigationData)
        {
            Version = "1.0";
        }

        private string _version;
        public string Version
        {
            get => _version;
            set
            {
                _version = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateToAcknowledgmentCommand => new Command(NavigateToAcknowledgmentCommandExecute);

        private async void NavigateToAcknowledgmentCommandExecute(object obj)
        {
            await NavigationService.NavigateToAsync(typeof(AcknowledgementViewModel), null);
        }

        public ICommand NavigateToAboutUsCommand => new Command(NavigateToAboutUsCommandExecute);

        private async void NavigateToAboutUsCommandExecute(object obj)
        {           
            await NavigationService.NavigateToAsync(typeof(AboutUsViewModel), null);
        }
        public ICommand NavigateToPrivacyCommand => new Command(NavigateToPrivacyCommandExecute);

        private void NavigateToPrivacyCommandExecute(object obj)
        {
            Device.OpenUri(new Uri("http://www.riojadotnet.com"));
        }
    }
}
