using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;

namespace XamaFilm.ViewModels
{
    public class DetailSerieViewModel : Base.ViewModelBase
    {
        public DetailSerieViewModel(Serie serie)
        {
            Serie = serie;
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
    }
}
