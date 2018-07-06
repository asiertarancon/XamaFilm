using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class DetailSerieViewModel : Base.ViewModelBase
    {
        public DetailSerieViewModel()
        {            
        }
        private Serie _serie;
        public Serie Serie
        {
            get => _serie;
            set
            {
                _serie = value;
                OnPropertyChanged();
            }
        }

        public async override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Serie serie)
            {
                Serie = serie;
            }
        }

        public ICommand ItemSelectedCommand => new Command<Season>(OnItemSelected);

        private void OnItemSelected(Season season)
        {
        }
    }
}
