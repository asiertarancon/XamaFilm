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
	public partial class DetailEpisodeView : ContentPage
	{
		public DetailEpisodeView ()
		{
			InitializeComponent ();

            var episode = new Episode()
            {
                Title = "Pilot",
                Year = "2008",
                Rated = "TV-MA",
                Released = "20 Jan 2008",
                Season = "1",
                EpisodeNumber = "1",
                Runtime = "58 min",
                Genre = "Crime, Drama, Thriller",
                Director = "Vince Gilligan",
                Writer = "Vince Gilligan (created by), Vince Gilligan",
                Actors = "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                Plot = "Diagnosed with terminal lung cancer, chemistry teacher Walter White teams up with his former student, Jesse Pinkman, to cook and sell crystal meth.",
                Language = "English",
                Country = "USA",
                Awards = "N/A",
                Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTZlMGY1OWItZWJiMy00MTZlLThhMGItNDQ2ODM3YzNkOWU5XkEyXkFqcGdeQXVyNzgyOTQ4MDc@._V1_SX300.jpg",
                Ratings = new List<Rating>
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.9/10" }
                    }                
            };

            Title = episode.Title;
            TitleLabel.Text = episode.Title;
            Image.Source = episode.Poster;

            GenreLabel.Text = episode.Genre;
            DirectorLabel.Text = episode.Director;
            ActorsLabel.Text = episode.Actors;
            AwardsLabel.Text = episode.Awards;
            PlotLabel.Text = episode.Plot;
        }
	}
}