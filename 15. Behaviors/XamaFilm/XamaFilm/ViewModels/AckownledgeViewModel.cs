using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class AcknowledgementViewModel : ViewModelBase
    {
        public AcknowledgementViewModel()
        {
            Licenses = new List<License>()
            {
                new License("Json.NET", "The MIT License", "https://www.newtonsoft.com/json"),
                new License("Xamarin Forms", "The MIT License", "https://www.xamarin.com/forms"),
                new License("Xamarin Forms Maps", "The MIT License", "https://www.xamarin.com/forms"),
            };
        }

        private List<License> _licenses;
        public List<License> Licenses
        {
            get => _licenses;
            set
            {
                _licenses = value;
                OnPropertyChanged();
            }
        }

        public ICommand ItemSelectedCommand => new Command<License>(OpenURL);

        public void OpenURL(License license)
        {
            Device.OpenUri(new Uri(license.URL));
        }
    }

    public class License : BindableObject
    {
        public string Title { get; set; }
        public string LicenseType { get; set; }
        public string URL { get; set; }

        public License(string title, string type, string url)
        {
            Title = title;
            LicenseType = type;
            URL = url;
        }
    }
}
