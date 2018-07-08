using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class FavoritesViewModel : Base.ViewModelBase
    {
        public FavoritesViewModel()
        {            
        }

        public async override Task InitializeAsync(object navigationData)
        {
            Movies = new ObservableCollection<Movie>(Barrel.Current.Get<List<Movie>>("favoriteList"));
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
            Movies.Remove(movie);
            Barrel.Current.Add("favoriteList", Movies.ToList(), TimeSpan.FromDays(1000));
        }
    }
}
