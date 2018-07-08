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
        public HomeViewModel(MoviesListViewModel moviesViewModel, SeriesListViewModel seriesViewModel)
        {
            MoviesListViewModel = moviesViewModel;            
            SeriesListViewModel = seriesViewModel;

        }

        public async override Task InitializeAsync(object navigationData)
        {
            await MoviesListViewModel.InitializeAsync(navigationData);
            await SeriesListViewModel.InitializeAsync(navigationData);
        }

        private MoviesListViewModel _moviesListViewModel;
        public MoviesListViewModel MoviesListViewModel
        {
            get => _moviesListViewModel;
            set
            {
                _moviesListViewModel = value;
                OnPropertyChanged();
            }
        }

        private SeriesListViewModel _seriesListViewModel;
        public SeriesListViewModel SeriesListViewModel
        {
            get => _seriesListViewModel;
            set
            {
                _seriesListViewModel = value;
                OnPropertyChanged();
            }
        }
    }
}
