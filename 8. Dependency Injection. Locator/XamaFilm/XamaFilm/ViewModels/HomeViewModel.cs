using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel()
        {
            InitializeAsync(null);
        }

        public async override Task InitializeAsync(object navigationData)
        {
            var service = new MockDataService();
            Movies = new ObservableCollection<Movie>(await service.GetMoviesAsync());
            Series = new ObservableCollection<Serie>(await service.GetSeriesAsync());
        }
        
        private ObservableCollection<Serie> _series;
        public ObservableCollection<Serie> Series
        {
            get => _series;
            set
            {
                _series = value;
                OnPropertyChanged();
            }
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

        public ICommand SerieItemSelectedCommand => new Command<Serie>(OnSerieItemSelected);

        private void OnSerieItemSelected(Serie serie)
        {
           
        }

        public ICommand MovieItemSelectedCommand => new Command<Movie>(OnMovieItemSelected);

        private void OnMovieItemSelected(Movie movie)
        {
        }
    }
}
