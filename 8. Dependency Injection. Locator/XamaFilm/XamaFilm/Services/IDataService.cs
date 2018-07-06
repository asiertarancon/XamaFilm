using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;

namespace XamaFilm.Services
{
    public interface IDataService
    {        
        Task<Movie> GetMovieByIdAsync(string id);
        Task<List<Movie>> GetMoviesAsync(bool forceRefresh = false);

        Task<Serie> GetSerieByIdAsync(string id);
        Task<List<Serie>> GetSeriesAsync(bool forceRefresh = false);

        Task<Season> GetSeasonBySerieIdSeasonIdAsync(string serieId, int seasonNumber);
        Task<List<Season>> GetSeasonsBySerieIdAsync(string serieId);
        
        Task<Episode> GetEpisodeBySeriesIdAsync(string seriesId, int seasonNumber, int episodeNumber);
        Task<Episode> GetEpisodeByIdAsync(string episodeId);
    }
}
