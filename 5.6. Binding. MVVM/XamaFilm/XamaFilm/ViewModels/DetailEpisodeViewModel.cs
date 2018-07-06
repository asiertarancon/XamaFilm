using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;

namespace XamaFilm.ViewModels
{
    public class DetailEpisodeViewModel : Base.ViewModelBase
    {
        public DetailEpisodeViewModel(Episode episode)
        {
            Episode = episode;
        }

        private Episode _episode;
        public Episode Episode
        {
            get => _episode;
            set
            {
                _episode = value;
                OnPropertyChanged();
            }
        }
    }
}
