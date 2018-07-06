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
    public class DetailSeasonSerieViewModel : Base.ViewModelBase
    {
        public DetailSeasonSerieViewModel()
        {            
        }

        private Season _season;
        public Season Season
        {
            get => _season;
            set
            {
                _season = value;
                OnPropertyChanged();
            }
        }

        public async override Task InitializeAsync(object navigationData)
        {
            if(navigationData is Season season)
            {
                Season = season;
            }
        }

        public ICommand ItemSelectedCommand => new Command<SeasonEpisode>(OnItemSelected);

        private void OnItemSelected(SeasonEpisode seasonEpisode)
        {
        }
    }
}
