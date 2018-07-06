using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.ViewModels;
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

            var season = new Services.MockDataService().GetSeasonBySerieIdSeasonIdAsync("tt0903747", 1).Result;
            BindingContext = new DetailSeasonSerieViewModel(season);
        }
	}
}