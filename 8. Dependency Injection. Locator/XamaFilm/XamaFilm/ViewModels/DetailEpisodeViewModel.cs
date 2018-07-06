using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.Services;

namespace XamaFilm.ViewModels
{
    public class DetailEpisodeViewModel : Base.ViewModelBase
    {
        private readonly IDataService _dataService;
        public DetailEpisodeViewModel(IDataService service)
        {
            _dataService = service;
        }

        private Episode _episode;
        public Episode Episode
        {
            get => _episode;
            set
            {
                _episode = value;
                OnPropertyChanged();
            }
        }

        public async override Task InitializeAsync(object navigationData)
        {
            if (navigationData is SeasonEpisode seasonEpisode)
            {
                Episode = await _dataService.GetEpisodeByIdAsync(seasonEpisode.ImdbId);                
            }
        }
    }
}
