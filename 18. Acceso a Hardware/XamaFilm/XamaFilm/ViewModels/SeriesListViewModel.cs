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
    public class SeriesListViewModel : Base.ViewModelBase
    {
        private readonly IDataService _dataService;
        public SeriesListViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        public async override Task InitializeAsync(object navigationData)
        {            
            Series = new ObservableCollection<Serie>(await _dataService.GetSeriesAsync());
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

        public ICommand SerieItemSelectedCommand => new Command<Serie>(OnSerieItemSelected);

        private async void OnSerieItemSelected(Serie serie)
        {
            await NavigationService.NavigateToAsync<DetailSerieViewModel>(serie);
        }
    }
}
