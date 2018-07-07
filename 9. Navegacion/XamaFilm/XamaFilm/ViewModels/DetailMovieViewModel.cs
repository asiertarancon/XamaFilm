using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;

namespace XamaFilm.ViewModels
{
    public class DetailMovieViewModel : Base.ViewModelBase
    {
        public DetailMovieViewModel()
        {        
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

        public async override Task InitializeAsync(object navigationData)
        {
            if (navigationData is Movie movie)
            {
                Movie = movie;
            }
        }
    }
}
