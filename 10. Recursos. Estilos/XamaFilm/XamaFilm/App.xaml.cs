using System;
using System.Threading.Tasks;
using XamaFilm.Services;
using XamaFilm.ViewModels.Base;
using XamaFilm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XamaFilm
{
	public partial class App : Application
	{
		public App ()
		{
            LiveReload.Init();

			InitializeComponent();

            InitNavigation();
        }

        private Task InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
