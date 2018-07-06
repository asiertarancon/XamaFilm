﻿using System;
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
	public partial class DetailEpisodeView : ContentPage
	{
		public DetailEpisodeView ()
		{
			InitializeComponent ();

            var episode = new Services.MockDataService().GetEpisodeBySeriesIdAsync("tt0903747", 1, 1).Result;

            BindingContext = new DetailEpisodeViewModel(episode);
        }
	}
}