using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.Services;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class DetailMovieViewModel : Base.ViewModelBase
    {
        private readonly IDataService _dataService;
        public DetailMovieViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
        private Movie _movie;
        public Movie Item
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
                Item = await _dataService.GetMovieByIdAsync(movie.ImdbId);                
            }
        }                
    }
}
