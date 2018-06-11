using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailFilmPage : ContentPage
	{
		public DetailFilmPage (Models.Movie movie)
		{
			InitializeComponent ();

            Title = movie.Title;
            titleLabel.Text = movie.Title;
            image.Source = movie.Poster;
            yearLabel.Text = movie.Year;
            genreLabel.Text = movie.Genre;
        }
	}
}