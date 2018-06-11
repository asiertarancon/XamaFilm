using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using Xamarin.Forms;

namespace XamaFilm
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var movies = new List<Movie>()
            {
                new Movie()
                {
                    Title = "Guardians of the Galaxy Vol. 2",
                    Year = "2017",
                    Rated = "PG-13",
                    Released = "05 May 2017",
                    Runtime = "136 min",
                    Genre = "Action, Adventure, Sci-Fi",
                    Director = "James Gunn",
                    Writer = "James Gunn, Dan Abnett (based on the Marvel comics by), Andy Lanning (based on the Marvel comics by), Steve Englehart (Star-lord created by), Steve Gan (Star-lord created by), Jim Starlin (Gamora and Drax created by), Stan Lee (Groot created by), Larry Lieber (Groot created by), Jack Kirby (Groot created by), Bill Mantlo (Rocket Raccoon created by), Keith Giffen (Rocket Raccoon created by), Steve Gerber (Howard the Duck created by), Val Mayerik (Howard the Duck created by)",
                    Actors = "Chris Pratt, Zoe Saldana, Dave Bautista, Vin Diesel",
                    Plot = "The Guardians must fight to keep their newfound family together as they unravel the mystery of Peter Quill's true parentage.",
                    Language = "English",
                    Country = "USA",
                    Awards = "Nominated for 1 Oscar. Another 12 wins & 42 nominations.",
                    Poster = "https://ia.media-imdb.com/images/M/MV5BMTg2MzI1MTg3OF5BMl5BanBnXkFtZTgwNTU3NDA2MTI@._V1_SX300.jpg",
                    Ratings= new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "7.7/10" },
                        new Rating() { Source = "Rotten Tomatoes", Value= "83%" },
                        new Rating() { Source = "Metacritic", Value= "67/100" },
                    }
                },
                new Movie()
                {
                    Title= "Star Wars: Episode V - The Empire Strikes Back",
                    Year= "1980",
                    Rated= "PG",
                    Released= "20 Jun 1980",
                    Runtime= "124 min",
                    Genre= "Action, Adventure, Fantasy",
                    Director= "Irvin Kershner",
                    Writer= "Leigh Brackett (screenplay by), Lawrence Kasdan (screenplay by), George Lucas (story by)",
                    Actors= "Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams",
                    Plot= "After the rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader.",
                    Language= "English",
                    Country= "USA",
                    Awards= "Won 1 Oscar. Another 21 wins & 19 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BYmU1NDRjNDgtMzhiMi00NjZmLTg5NGItZDNiZjU5NTU4OTE0XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX300.jpg",
                    Website= "http://www.starwars.com/episode-v/",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.8/10" },
                        new Rating() { Source = "Rotten Tomatoes", Value= "94%" },
                        new Rating() { Source = "Metacritic", Value= "82/100" },
                    }
                },
                new Movie()
                {
                    Title= "Back to the Future",
                    Year= "1985",
                    Rated= "PG",
                    Released= "03 Jul 1985",
                    Runtime= "116 min",
                    Genre= "Adventure, Comedy, Sci-Fi",
                    Director= "Robert Zemeckis",
                    Writer= "Robert Zemeckis, Bob Gale",
                    Actors= "Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover",
                    Plot= "Marty McFly, a 17-year-old high school student, is accidentally sent thirty years into the past in a time-traveling DeLorean invented by his close friend, the maverick scientist Doc Brown.",
                    Language= "English",
                    Country= "USA",
                    Awards= "Won 1 Oscar. Another 19 wins & 25 nominations.",
                    Website= "http://www.bttfmovie.com/",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BZmU0M2Y1OGUtZjIxNi00ZjBkLTg1MjgtOWIyNThiZWIwYjRiXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.5/10" },
                        new Rating() { Source = "Rotten Tomatoes", Value= "96%" },
                        new Rating() { Source = "Metacritic", Value= "86/100" },
                    }
                },
                new Movie()
                {
                    Title= "Interstellar",
                    Year= "2014",
                    Rated= "PG-13",
                    Released= "07 Nov 2014",
                    Runtime= "169 min",
                    Genre= "Adventure, Drama, Sci-Fi",
                    Director= "Christopher Nolan",
                    Writer= "Jonathan Nolan, Christopher Nolan",
                    Actors= "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow",
                    Plot= "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    Language= "English",
                    Country= "USA, UK",
                    Awards= "Won 1 Oscar. Another 43 wins & 143 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BZjdkOTU3MDktN2IxOS00OGEyLWFmMjktY2FiMmZkNWIyODZiXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SX300.jpg",
                    Website= "http://www.InterstellarMovie.com/",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.6/10" },
                        new Rating() { Source = "Rotten Tomatoes", Value= "71%" },
                        new Rating() { Source = "Metacritic", Value= "74/100" },
                    }
                },
                new Movie()
                {
                    Title= "Matrix",
                    Year= "1993",
                    Rated= "N/A",
                    Released= "01 Mar 1993",
                    Runtime= "60 min",
                    Genre= "Action, Drama, Fantasy",
                    Director= "N/A",
                    Writer= "Grenville Case",
                    Actors= "Nick Mancuso, Phillip Jarrett, Carrie-Anne Moss, John Vernon",
                    Plot= "Steven Matrix is one of the underworld's foremost hitmen until his luck runs out, and someone puts a contract out on him. Shot in the forehead by a .22 pistol, Matrix \"dies\" and finds ...",
                    Language= "English",
                    Country= "Canada",
                    Awards= "1 win.",
                    Poster= "https://images-na.ssl-images-amazon.com/images/M/MV5BYzUzOTA5ZTMtMTdlZS00MmQ5LWFmNjEtMjE5MTczN2RjNjE3XkEyXkFqcGdeQXVyNTc2ODIyMzY@._V1_SX300.jpg",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.4/10" },
                    }
                }
            };

            list.ItemsSource = movies;
            list.ItemTapped += List_ItemTapped;
        }

        private void List_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new DetailFilmPage(e.Item as Movie));
        }
    }
}
