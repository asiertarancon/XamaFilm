using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;

namespace XamaFilm.ViewModels
{
    public class DetailSeasonSerieViewModel : Base.ViewModelBase
    {
        public DetailSeasonSerieViewModel(Season season)
        {
            Season = season;
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
    }
}
