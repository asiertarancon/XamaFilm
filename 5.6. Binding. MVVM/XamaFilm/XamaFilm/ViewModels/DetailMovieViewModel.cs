using System;
using System.Collections.Generic;
using System.Text;
using XamaFilm.Models;

namespace XamaFilm.ViewModels
{
    public class DetailMovieViewModel : Base.ViewModelBase
    {
        public DetailMovieViewModel(Movie movie)
        {
            Movie = movie;            
        }
        private Movie _movie;
        public Movie Movie
        {
            get => _movie;
            set
            {
                _movie = value;
                OnPropertyChanged();
            }
        }
    }
}
