using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailSeasonSerieView : ContentPage
	{
		public DetailSeasonSerieView ()
		{
			InitializeComponent ();

            var season = new SeasonDetails()
            {
                Title= "Breaking Bad",
                Season = "1",
                totalSeasons = "5",
                Episodes = new List<EpisodeDetails>()
                {
                    new EpisodeDetails()
                    {
                        Title= "Pilot",
                        Released= "2008-01-20",
                        Episode= "1",
                        imdbRating= "8.9",
                        //imdbID= "tt0959621"
                    },
                    new EpisodeDetails()
                    {
                        Title= "Cat's in the Bag...",
                        Released= "2008-01-27",
                        Episode= "2",
                        imdbRating= "8.7",
                        //imdbID= "tt1054724"
                    },
                    new EpisodeDetails()
                    {
                        Title= "...And the Bag's in the River",
                        Released= "2008-02-10",
                        Episode= "3",
                        imdbRating= "8.7",
                       // imdbID= "tt1054725"
                    },
                    new EpisodeDetails()
                    {
                        Title= "Cancer Man",
                        Released= "2008-02-17",
                        Episode= "4",
                        imdbRating= "8.3",
                       // imdbID= "tt1054726"
                    },
                    new EpisodeDetails()
                    {
                        Title= "Gray Matter",
                        Released= "2008-02-24",
                        Episode= "5",
                        imdbRating= "8.3",
                        //imdbID= "tt1054727"
                    },
                    new EpisodeDetails()
                    {
                        Title= "Crazy Handful of Nothin'",
                        Released= "2008-03-02",
                        Episode= "6",
                        imdbRating= "9.2",
                       // imdbID= "tt1054728"
                    },
                    new EpisodeDetails()
                    {
                        Title= "A No-Rough-Stuff-Type Deal",
                        Released= "2008-03-09",
                        Episode= "7",
                        imdbRating= "8.8",
                       // imdbID= "tt1054729"
                    }
                }    

            };

            TitleLabel.Text = season.Title;
            SeasonLabel.Text = season.Season;
            TotalSeasonsLabel.Text = season.totalSeasons;

        }
	}
}