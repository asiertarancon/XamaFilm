using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamaFilm.Views.Templates
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailTemplate : ContentView
	{
		public DetailTemplate ()
		{
			InitializeComponent ();

            LoadAnimations();
        }

        private async void LoadAnimations()
        {            
            await Task.WhenAny(
                ImageStackLayout.FadeTo(1, 1000),
                PlotLabel.TranslateTo(-10, 0, 600, Easing.BounceIn),
                FactsStackLayout.TranslateTo(0, 30, 600)
            );

            await Task.WhenAll(
                PlotLabel.TranslateTo(0, 0, 300),
                FactsStackLayout.TranslateTo(0, 0, 300)
            );
        }
	}
}