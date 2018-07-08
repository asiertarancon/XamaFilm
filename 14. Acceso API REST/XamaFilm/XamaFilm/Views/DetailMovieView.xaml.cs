using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailMovieView : ContentPage
	{
        public DetailMovieView()
        {
            InitializeComponent();

            MessagingCenter.Instance.Subscribe<Movie>(this, "MovieChanged", (movie) =>
            {
                AddPins(movie);
            });
        }

        private void AddPins(Movie movie)
        {
            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(movie.Latitude, movie.Longitude),
                Label = movie.Title
            };

            map.Pins.Add(pin);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(pin.Position, Distance.FromKilometers(500)));
        }
    }
}