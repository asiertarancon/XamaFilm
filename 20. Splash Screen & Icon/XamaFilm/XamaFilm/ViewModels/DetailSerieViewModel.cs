using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using XamaFilm.Models;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class DetailSerieViewModel : Base.ViewModelBase
    {
        private readonly IDataService _dataService;
        public DetailSerieViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }
        private Serie _serie;
        public Serie Item
        {
            get => _serie;
            set
            {
                _serie = value;
                OnPropertyChanged();
            }
        }

        public async override Task InitializeAsync(object navigationData)
        {
            try
            {
                // Use default vibration length
                Vibration.Vibrate();

                if (navigationData is Serie serie)
                {
                    Item = await _dataService.GetSerieByIdAsync(serie.ImdbId);
                }
            }
            catch (FeatureNotSupportedException ex)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Other error has occurred.
            }
        }

        public ICommand ItemSelectedCommand => new Command<Season>(OnItemSelected);

        private async void OnItemSelected(Season season)
        {
            await ViewModelLocator.Instance.Resolve<INavigationService>().NavigateToAsync<DetailSeasonSerieViewModel>(season);
        }
    }
}
