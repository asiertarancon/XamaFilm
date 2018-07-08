using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;

namespace XamaFilm.Services
{
    public class MockDataService : IDataService
    {
        public MockDataService()
        {
            Movies = new List<Movie>()
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
                    ImdbRating = "7.7",
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
                    ImdbRating = "8.8",
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
                    ImdbRating = "8.5",
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
                    ImdbRating = "8.6",
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
                    ImdbRating = "8.4",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.4/10" },
                    }
                }
            };

            Series = new List<Serie>()
            {
                new Serie()
                {
                    Title= "Breaking Bad",
                    Year= "2008–2013",
                    Rated= "TV-MA",
                    Released= "20 Jan 2008",
                    Runtime= "49 min",
                    Genre= "Crime, Drama, Thriller",
                    Director= "N/A",
                    Writer= "Vince Gilligan",
                    Actors= "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                    Plot= "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.",
                    Language= "English, Spanish",
                    Country= "USA",
                    Awards= "Won 2 Golden Globes. Another 144 wins & 225 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BZDNhNzhkNDctOTlmOS00NWNmLWEyODQtNWMxM2UzYmJiNGMyXkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_SX300.jpg",
                    ImdbRating = "9.5",
                    TotalSeasons= "5",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "9.5/10" },
                    },
                    Type = "series",
                    ImdbId = "tt0903747",
                    Seasons = new List<Season>()
                    {
                        new Season()
                        {
                            SeasonNumber = "1",
                            Title = "Breaking Bad",
                            TotalSeasons = "5",
                            Episodes = new List<SeasonEpisode>()
                            {
                                new SeasonEpisode()
                                {
                                    Title= "Pilot",
                                    Released= "2008-01-20",
                                    Episode= "1",
                                    ImdbRating= "8.9",
                                    ImdbId= "tt0959621"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Cat's in the Bag...",
                                    Released= "2008-01-27",
                                    Episode= "2",
                                    ImdbRating= "8.7",
                                    ImdbId= "tt1054724"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "...And the Bag's in the River",
                                    Released= "2008-02-10",
                                    Episode= "3",
                                    ImdbRating= "8.7",
                                    ImdbId= "tt1054725"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Cancer Man",
                                    Released= "2008-02-17",
                                    Episode= "4",
                                    ImdbRating= "8.3",
                                    ImdbId= "tt1054726"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Gray Matter",
                                    Released= "2008-02-24",
                                    Episode= "5",
                                    ImdbRating= "8.3",
                                    ImdbId= "tt1054727"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Crazy Handful of Nothin'",
                                    Released= "2008-03-02",
                                    Episode= "6",
                                    ImdbRating= "9.2",
                                    ImdbId= "tt1054728"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "A No-Rough-Stuff-Type Deal",
                                    Released= "2008-03-09",
                                    Episode= "7",
                                    ImdbRating= "8.8",
                                    ImdbId= "tt1054729"
                                }
                            },
                        },
                        new Season()
                        {
                             Title= "Breaking Bad",
                             SeasonNumber = "2",
                             TotalSeasons = "5",
                             Episodes = new List<SeasonEpisode>()
                             {
                                 new SeasonEpisode()
                                 {
                                    Title= "Seven Thirty-Seven",
                                    Released= "2009-03-08",
                                    Episode= "1",
                                    ImdbRating= "8.7",
                                    ImdbId= "tt1232244"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Grilled",
                                    Released= "2009-03-15",
                                    Episode= "2",
                                    ImdbRating= "9.2",
                                    ImdbId= "tt1232249"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Bit by a Dead Bee",
                                    Released= "2009-03-22",
                                    Episode= "3",
                                    ImdbRating= "8.4",
                                    ImdbId= "tt1232250"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Down",
                                    Released= "2009-03-29",
                                    Episode= "4",
                                    ImdbRating= "8.3",
                                    ImdbId= "tt1232251"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Breakage",
                                    Released= "2009-04-05",
                                    Episode= "5",
                                    ImdbRating= "8.3",
                                    ImdbId= "tt1232252"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Peekaboo",
                                    Released= "2009-04-12",
                                    Episode= "6",
                                    ImdbRating= "8.8",
                                    ImdbId= "tt1232253"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Negro Y Azul",
                                    Released= "2009-04-19",
                                    Episode= "7",
                                    ImdbRating= "8.7",
                                    ImdbId= "tt1232254"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Better Call Saul",
                                    Released= "2009-04-26",
                                    Episode= "8",
                                    ImdbRating= "9.0",
                                    ImdbId= "tt1232255"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "4 Days Out",
                                    Released= "2009-05-03",
                                    Episode= "9",
                                    ImdbRating= "8.9",
                                    ImdbId= "tt1232256"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Over",
                                    Released= "2009-05-10",
                                    Episode= "10",
                                    ImdbRating= "8.6",
                                    ImdbId= "tt1232245"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Mandala",
                                    Released= "2009-05-17",
                                    Episode= "11",
                                    ImdbRating= "8.8",
                                    ImdbId= "tt1232246"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "Phoenix",
                                    Released= "2009-05-24",
                                    Episode= "12",
                                    ImdbRating= "9.1",
                                    ImdbId= "tt1232247"
                                },
                                 new SeasonEpisode()
                                {
                                    Title= "ABQ",
                                    Released= "2009-05-31",
                                    Episode= "13",
                                    ImdbRating= "9.1",
                                    ImdbId= "tt1232248"
                                }
                             }
                        }

                    }

                },
                new Serie()
                {
                    Title= "Game of Thrones",
                    Year= "2011–",
                    Rated= "TV-MA",
                    Released= "17 Apr 2011",
                    Runtime= "57 min",
                    Genre= "Action, Adventure, Drama",
                    Director= "N/A",
                    Writer= "David Benioff, D.B. Weiss",
                    Actors= "Peter Dinklage, Lena Headey, Emilia Clarke, Kit Harington",
                    Plot= "Nine noble families fight for control over the mythical lands of Westeros, while an ancient enemy returns after being dormant for thousands of years.",
                    Language= "English",
                    Country= "USA, UK",
                    Awards= "Won 1 Golden Globe. Another 273 wins & 454 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BMjE3NTQ1NDg1Ml5BMl5BanBnXkFtZTgwNzY2NDA0MjI@._V1_SX300.jpg",
                    ImdbRating = "9.5",
                    TotalSeasons= "7",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "9.5/10" },
                    },
                    Type = "series",
                    ImdbId = "tt0944947",
                    Seasons = new List<Season>()
                    {
                        new Season()
                        {
                            Title= "Game of Thrones",
                            SeasonNumber = "1",
                            TotalSeasons= "8",
                            Episodes = new List<SeasonEpisode>()
                            {
                                new SeasonEpisode()
                                 {
                                    Title= "Winter Is Coming",
                                    Released= "2011-04-17",
                                    Episode= "1",
                                    ImdbRating= "9.0",
                                    ImdbId= "tt1480055"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "The Kingsroad",
                                    Released= "2011-04-24",
                                    Episode= "2",
                                    ImdbRating= "8.8",
                                    ImdbId= "tt1668746"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Lord Snow",
                                    Released= "2011-05-01",
                                    Episode= "3",
                                    ImdbRating= "8.7",
                                    ImdbId= "tt1829962"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Cripples, Bastards, and Broken Things",
                                    Released= "2011-05-08",
                                    Episode= "4",
                                    ImdbRating= "8.8",
                                    ImdbId= "tt1829963"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "The Wolf and the Lion",
                                    Released= "2011-05-15",
                                    Episode= "5",
                                    ImdbRating= "9.1",
                                    ImdbId= "tt1829964"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "A Golden Crown",
                                    Released= "2011-05-22",
                                    Episode= "6",
                                    ImdbRating= "9.2",
                                    ImdbId= "tt1837862"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "You Win or You Die",
                                    Released= "2011-05-29",
                                    Episode= "7",
                                    ImdbRating= "9.3",
                                    ImdbId= "tt1837863"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "The Pointy End",
                                    Released= "2011-06-05",
                                    Episode= "8",
                                    ImdbRating= "9.1",
                                    ImdbId= "tt1837864"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Baelor",
                                    Released= "2011-06-12",
                                    Episode= "9",
                                    ImdbRating= "9.6",
                                    ImdbId= "tt1851398"
                                },
                                new SeasonEpisode()
                                {
                                    Title= "Fire and Blood",
                                    Released= "2011-06-19",
                                    Episode= "10",
                                    ImdbRating= "9.5",
                                    ImdbId= "tt1851397"
                                }
                            }
                        }
                    }
                },
                new Serie()
                {
                    Title= "Rick and Morty",
                    Year= "2013–",
                    Rated= "TV-14",
                    Released= "02 Dec 2013",
                    Runtime= "23 min",
                    Genre= "Animation, Adventure, Comedy",
                    Director= "N/A",
                    Writer= "Dan Harmon, Justin Roiland",
                    Actors= "Justin Roiland, Chris Parnell, Spencer Grammer, Sarah Chalke",
                    Plot= "An animated series that follows the exploits of a super scientist and his not-so-bright grandson.",
                    Language= "English",
                    Country= "USA",
                    Awards= "13 wins & 9 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BMjRiNDRhNGUtMzRkZi00MThlLTg0ZDMtNjc5YzFjYmFjMmM4XkEyXkFqcGdeQXVyNzQ1ODk3MTQ@._V1_SX300.jpg",
                    ImdbRating = "9.3",
                    TotalSeasons= "4",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "9.3/10" },
                    }
                },
                new Serie()
                {
                    Title= "Futurama",
                    Year= "1999–2013",
                    Rated= "TV-14",
                    Released= "28 Mar 1999",
                    Runtime= "22 min",
                    Genre= "Animation, Comedy, Sci-Fi",
                    Director= "N/A",
                    Writer= "David X. Cohen, Matt Groening",
                    Actors= "Billy West, Katey Sagal, John DiMaggio, Tress MacNeille",
                    Plot= "Fry, a pizza guy, is accidentally frozen in 1999 and thawed out New Year's Eve 2999.",
                    Language= "English",
                    Country= "USA",
                    Awards= "Won 6 Primetime Emmys. Another 24 wins & 56 nominations.",
                    Poster= "https://ia.media-imdb.com/images/M/MV5BNzA2ZDk2ZTUtMWU2Yi00NDVmLTk1ODEtMmFmMjQyNWYzODI0XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg",
                    ImdbRating = "8.5",
                    TotalSeasons= "7",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.5/10" },
                    }
                },
                new Serie()
                {
                    Title= "The Wire",
                    Year= "2002–2008",
                    Rated= "TV-MA",
                    Released= "02 Jun 2002",
                    Runtime= "59 min",
                    Genre= "Crime, Drama, Thriller",
                    Director= "N/A",
                    Writer= "David Simon",
                    Actors= "Dominic West, John Doman, Deirdre Lovejoy, Wendell Pierce",
                    Plot= "Baltimore drug scene, seen through the eyes of drug dealers and law enforcement.",
                    Language= "English, Greek, Mandarin, Spanish",
                    Country= "USA",
                    Awards= "Nominated for 2 Primetime Emmys. Another 14 wins & 51 nominations.",
                    Poster= "https://m.media-amazon.com/images/M/MV5BNjc1NzYwODEyMV5BMl5BanBnXkFtZTcwNTcxMzU1MQ@@._V1_SX300.jpg",
                    ImdbRating = "9.3",
                    TotalSeasons= "5",
                    Ratings = new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "9.3/10" },
                    }
                }
            };

            Episodes = new List<Episode>()
            {
                new Episode()
                {
                    Title= "Pilot",
                    Year= "2008",
                    Rated= "TV-MA",
                    Released= "20 Jan 2008",
                    SeasonNumber= "1",
                    EpisodeNumber= "1",
                    Runtime= "58 min",
                    Genre= "Crime, Drama, Thriller",
                    Director= "Vince Gilligan",
                    Writer= "Vince Gilligan (created by), Vince Gilligan",
                    Actors= "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                    Plot= "Diagnosed with terminal lung cancer, chemistry teacher Walter White teams up with his former student, Jesse Pinkman, to cook and sell crystal meth.",
                    Language= "English",
                    Country= "USA",
                    Awards= "N/A",
                    Poster= "https://images-na.ssl-images-amazon.com/images/M/MV5BNTZlMGY1OWItZWJiMy00MTZlLThhMGItNDQ2ODM3YzNkOWU5XkEyXkFqcGdeQXVyNzgyOTQ4MDc@._V1_SX300.jpg",
                    Ratings= new List<Rating>()
                    {
                        new Rating() { Source = "Internet Movie Database", Value= "8.9/10" },
                    },
                    ImdbRating= "8.9",
                    ImdbId= "tt0959621",
                    SerieId= "tt0903747",
                    Type= "episode"
                },
                new Episode()
                {
                    Title= "Cat's in the Bag...",
                    Year= "2008",
                    Rated= "TV-14",
                    Released= "27 Jan 2008",
                    SeasonNumber= "1",
                    EpisodeNumber= "2",
                    Runtime= "48 min",
                    Genre= "Crime, Drama, Thriller",
                    Director= "Adam Bernstein",
                    Writer= "Vince Gilligan (created by), Vince Gilligan",
                    Actors= "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris",
                    Plot= "After their first drug deal goes terribly wrong, Walt and Jesse are forced to deal with a corpse and a prisoner. Meanwhile, Skyler grows suspicious of Walt's activities.",
                    Language= "English",
                    Country= "USA",
                    Awards= "N/A",
                    Poster= "https://images-na.ssl-images-amazon.com/images/M/MV5BY2I2YTkzNjEtZTViMy00OWJiLWIyMTAtYzc1MmRlZTNlZDkzL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjk5MDYxNDM@._V1_SX300.jpg",
                    Ratings= new List<Rating>()
                                    {
                                        new Rating() { Source = "Internet Movie Database", Value= "8.7/10" },
                                    },                    
                    ImdbRating= "8.7",                    
                    ImdbId= "tt1054724",
                    SerieId= "tt0903747",
                    Type= "episode",
                }

            };
        }

        public List<Serie> Series { get; set; }
        public List<Movie> Movies { get; set; }

        public List<Episode> Episodes { get; set; }

        public Task<Episode> GetEpisodeByIdAsync(string episodeId)
        {
            return Task.FromResult(Episodes.FirstOrDefault(e => e.ImdbId == episodeId));
        }

        public Task<Episode> GetEpisodeBySeriesIdAsync(string seriesId, int seasonNumber, int episodeNumber)
        {
            return Task.FromResult(Episodes.FirstOrDefault(episode => episode.SerieId == seriesId 
                                                                      && episode.SeasonNumber == seasonNumber.ToString() 
                                                                      && episode.EpisodeNumber == episodeNumber.ToString()));
        }

        public Task<Movie> GetMovieByIdAsync(string id)
        {
            return Task.FromResult(Movies.FirstOrDefault(movie => movie.ImdbId == id));
        }

        public Task<List<Movie>> GetMoviesAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Movies);
        }

        public async Task<Season> GetSeasonBySerieIdSeasonIdAsync(string serieId, int seasonNumber)
        {
            var serie = await GetSerieByIdAsync(serieId);
            return serie.Seasons.FirstOrDefault(s => s.SeasonNumber == seasonNumber.ToString());
        }

        public async Task<List<Season>> GetSeasonsBySerieIdAsync(string serieId)
        {
            var serie = await GetSerieByIdAsync(serieId);
            return serie.Seasons;
        }

        public Task<Serie> GetSerieByIdAsync(string id)
        {
            return Task.FromResult(Series.FirstOrDefault(s => s.ImdbId == id));
        }

        public Task<List<Serie>> GetSeriesAsync(bool forceRefresh = false)
        {
            return Task.FromResult(Series);
        }
    }
}
