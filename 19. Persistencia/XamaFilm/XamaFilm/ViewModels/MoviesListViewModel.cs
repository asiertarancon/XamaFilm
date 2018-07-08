using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.Services;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class MoviesListViewModel : Base.ViewModelBase
    {
        private readonly IDataService _dataService;
        public MoviesListViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async override Task InitializeAsync(object navigationData)
        {
            Movies = new ObservableCollection<Movie>(await _dataService.GetMoviesAsync());
        }
        private ObservableCollection<Movie> _movies;
        public ObservableCollection<Movie> Movies
        {
            get => _movies;
            set
            {
                _movies = value;
                OnPropertyChanged();
            }
        }

        public ICommand MovieItemSelectedCommand => new Command<Movie>(OnMovieItemSelected);

        private async void OnMovieItemSelected(Movie movie)
        {
            await NavigationService.NavigateToAsync<DetailMovieViewModel>(movie);
        }
    }
}
