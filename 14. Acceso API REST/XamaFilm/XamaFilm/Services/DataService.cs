using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;

namespace XamaFilm.Services
{
    public class DataService : IDataService
    {
        private const string API = "http://www.omdbapi.com/?apikey=344d0d7b";//&i=tt0944947&Season=1

        private readonly IRequestService _requestService;
        public DataService(IRequestService service)
        {
            _requestService = service;
        }

        public async Task<Episode> GetEpisodeByIdAsync(string episodeId)
        {
            //http://www.omdbapi.com/?apikey=xxx&i=tt0944947
            var apiUri = $"{API}&i={episodeId}";
            return await _requestService.GetAsync<Episode>(apiUri);
        }

        public async Task<Episode> GetEpisodeBySeriesIdAsync(string seriesId, int seasonNumber, int episodeNumber)
        {
            //http://www.omdbapi.com/?apikey=xxx&i=tt0944947&Season=1&Episode=1
            var apiUri = $"{API}&i={seriesId}&Season={seasonNumber}&Episode={episodeNumber}";
            return await _requestService.GetAsync<Episode>(apiUri);
        }

        public async Task<Movie> GetMovieByIdAsync(string id)
        {
            //http://www.omdbapi.com/?apikey=xxx&i=tt0944947
            var apiUri = $"{API}&i={id}";
            return await _requestService.GetAsync<Movie>(apiUri);
        }

        public async Task<List<Movie>> GetMoviesAsync(bool forceRefresh = false)
        {
            var apiUri = $"{API}&s=batman&type=movie";
            var search =  await _requestService.GetAsync<SearchList>(apiUri);
            List<Movie> movies = new List<Movie>();
            foreach(var searchItem in search.Search)
            {
                movies.Add(new Movie()
                {
                    Title = searchItem.Title,
                    Year = searchItem.Year,
                    ImdbId = searchItem.ImdbID,
                    Type = searchItem.Type,
                    Poster = searchItem.Poster
                });
            }
            return movies;
        }

        public async Task<Season> GetSeasonBySerieIdSeasonIdAsync(string serieId, int seasonNumber)
        {
            //http://www.omdbapi.com/?apikey=xxx&i=tt0944947&Season=1&Episode=1
            var apiUri = $"{API}&i={serieId}&Season={seasonNumber}";
            return await _requestService.GetAsync<Season>(apiUri);
        }

        public async Task<List<Season>> GetSeasonsBySerieIdAsync(string serieId)
        {
            var apiUri = $"{API}&i={serieId}";
            return await _requestService.GetAsync<List<Season>>(apiUri);
        }

        public async Task<Serie> GetSerieByIdAsync(string id)
        {
            var apiUri = $"{API}&i={id}";
            var serie = await _requestService.GetAsync<Serie>(apiUri);
            int seasons = Convert.ToInt32(serie.TotalSeasons);
            serie.Seasons = new List<Season>();
            for(int i=1; i<= seasons; i++)
            {
                var season = await GetSeasonBySerieIdSeasonIdAsync(id, i);
                serie.Seasons.Add(season);
            }
            return serie;
        }

        public async Task<List<Serie>> GetSeriesAsync(bool forceRefresh = false)
        {
            var apiUri = $"{API}&s=batman&type=series";
            var res =  await _requestService.GetAsync<SearchList>(apiUri);

            var search = await _requestService.GetAsync<SearchList>(apiUri);
            List<Serie> movies = new List<Serie>();
            foreach (var searchItem in search.Search)
            {
                movies.Add(new Serie()
                {
                    Title = searchItem.Title,
                    Year = searchItem.Year,
                    ImdbId = searchItem.ImdbID,
                    Type = searchItem.Type,
                    Poster = searchItem.Poster
                });
            }
            return movies;
        }
    }
}