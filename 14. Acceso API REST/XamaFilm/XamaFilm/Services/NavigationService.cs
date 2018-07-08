using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.ViewModels;
using XamaFilm.ViewModels.Base;
using XamaFilm.Views;
using Xamarin.Forms;

namespace XamaFilm.Services
{
    public class NavigationService : INavigationService
    {
        protected readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication
        {
            get
            {
                return Application.Current;
            }
        }
        public NavigationService()
        {            
            _mappings = new Dictionary<Type, Type>();
            CreatePageViewModelMappings();         
        }

        private void CreatePageViewModelMappings()
        {
            _mappings.Add(typeof(AboutUsViewModel), typeof(AboutUsView));
            _mappings.Add(typeof(AcknowledgementViewModel), typeof(AcknowledgeView));
            _mappings.Add(typeof(DetailEpisodeViewModel), typeof(DetailEpisodeView));
            _mappings.Add(typeof(DetailMovieViewModel), typeof(DetailMovieView));
            _mappings.Add(typeof(DetailSeasonSerieViewModel), typeof(DetailSeasonSerieView));
            _mappings.Add(typeof(DetailSerieViewModel), typeof(DetailSerieView));
            _mappings.Add(typeof(FavoritesViewModel), typeof(FavoritesView));            
            _mappings.Add(typeof(HomeViewModel), typeof(HomeView));
            _mappings.Add(typeof(LoginViewModel), typeof(LoginView));
            _mappings.Add(typeof(MasterViewModel), typeof(MasterView));
            _mappings.Add(typeof(MenuViewModel), typeof(MenuView));
            _mappings.Add(typeof(MoviesListViewModel), typeof(MoviesListView));
            _mappings.Add(typeof(SeriesListViewModel), typeof(SeriesListView));            
            _mappings.Add(typeof(SettingsViewModel), typeof(SettingsView));
            _mappings.Add(typeof(WatchlistViewModel), typeof(WatchListView));
        }

        public Task InitializeAsync()
        {
            var isAuthenticated = true; //Pendiente para futuras clases
            if (isAuthenticated)
            {
                return NavigateToAsync<MasterViewModel>();
            }
            else
            {
                return NavigateToAsync<LoginViewModel>();
            }
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), null);
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            return InternalNavigateToAsync(typeof(TViewModel), parameter);
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            return InternalNavigateToAsync(viewModelType, null);
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            return InternalNavigateToAsync(viewModelType, parameter);
        }

        public async Task NavigateBackAsync()
        {
            if (CurrentApplication.MainPage is MasterView)
            {
                var mainPage = CurrentApplication.MainPage as MasterView;
                await mainPage.Detail.Navigation.PopAsync();
            }
            else if (CurrentApplication.MainPage != null)
            {
                await CurrentApplication.MainPage.Navigation.PopAsync();
            }
        }

        protected virtual async Task InternalNavigateToAsync(Type viewModelType, object parameter)
        {
            Page page = CreateAndBindPage(viewModelType, parameter);

            if (page is MasterView)
            {
                CurrentApplication.MainPage = page;
            }
            else if (page is LoginView)
            {
                CurrentApplication.MainPage = new NavigationPage(page);
            }
            else if (CurrentApplication.MainPage is MasterView)
            {
                var mainPage = CurrentApplication.MainPage as MasterView;

                if (mainPage.Detail is NavigationPage navigationPage)
                {
                    var currentPage = navigationPage.CurrentPage;

                    if (currentPage.GetType() != page.GetType() || (currentPage.GetType() == page.GetType() && page.GetType() != typeof(HomeView)))
                    {
                        await navigationPage.PushAsync(page);
                    }
                }
                else
                {
                    navigationPage = new NavigationPage(page);
                    mainPage.Detail = navigationPage;
                }

                mainPage.IsPresented = false;
            }
            else
            {
                if (CurrentApplication.MainPage is NavigationPage navigationPage)
                {
                    await navigationPage.PushAsync(page);
                }
                else
                {
                    CurrentApplication.MainPage = new NavigationPage(page);
                }
            }

            if (page.BindingContext != null)
                await (page.BindingContext as ViewModelBase).InitializeAsync(parameter);
        }

        protected Page CreateAndBindPage(Type viewModelType, object parameter)
        {
            Type pageType = GetPageTypeForViewModel(viewModelType);

            if (pageType == null)
            {
                throw new Exception($"Mapping type for {viewModelType} is not a page");
            }

            Page page = Activator.CreateInstance(pageType) as Page;
            ViewModelLocator locator = ViewModelLocator.Instance;
            ViewModelBase viewModel = locator.Resolve(viewModelType) as ViewModelBase;
            page.BindingContext = viewModel;

            return page;
        }

        protected Type GetPageTypeForViewModel(Type viewModelType)
        {
            if (!_mappings.ContainsKey(viewModelType))
            {
                throw new KeyNotFoundException($"No map for ${viewModelType} was found on navigation mappings");
            }

            return _mappings[viewModelType];
        }

        public void ClearStack()
        {
            var mainPage = CurrentApplication.MainPage as MasterView;
            if (mainPage.Detail is NavigationPage navigationPage)
            {
                navigationPage.PopToRootAsync(true);                
            }
        }
    }
}
