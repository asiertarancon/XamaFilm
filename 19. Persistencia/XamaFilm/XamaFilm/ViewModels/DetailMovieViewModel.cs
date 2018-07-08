using MonkeyCache.FileStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

        public ICommand FavoriteCommand => new Command(OnFavoriteCommand);

        private void OnFavoriteCommand(object obj)
        {            
            var favorites = Barrel.Current.Get<List<Movie>>("favoriteList");
            if (favorites != null)
            {                
                if(!favorites.Any(i=> i.ImdbId == Item.ImdbId))
                    favorites.Add(Item);
            }
            else
            {
                favorites = new List<Movie>() { Item };                    
            }
            Barrel.Current.Add("favoriteList", favorites, TimeSpan.FromDays(1000));            
        }
    }
}
