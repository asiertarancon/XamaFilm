using System;
using System.Collections.Generic;

using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamaFilm.Models;
using XamaFilm.Services;
using System.Windows.Input;

namespace XamaFilm.ViewModels
{
    public class MenuViewModel : Base.ViewModelBase
    {
        ObservableCollection<MasterViewMenuItem> _menuItems = new ObservableCollection<MasterViewMenuItem>();
        public ObservableCollection<MasterViewMenuItem> MenuItems
        {
            get => _menuItems;
            set
            {
                _menuItems = value;
                OnPropertyChanged();
            }
        }

        public MenuViewModel()
        {
            InitMenuItems();
        }
       
        private void InitMenuItems()
        {         
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "HOME",
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            });            
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "MOVIES",
                MenuItemType = MenuItemType.Movies,
                ViewModelType = typeof(MoviesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "SERIES",
                MenuItemType = MenuItemType.Series,
                ViewModelType = typeof(SeriesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "FAVORITES",
                MenuItemType = MenuItemType.Favorites,
                ViewModelType = typeof(FavoritesViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "WATCHLIST",
                MenuItemType = MenuItemType.Watchlist,
                ViewModelType = typeof(WatchlistViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = "SETTINGS",
                MenuItemType = MenuItemType.Settings,
                ViewModelType = typeof(SettingsViewModel),
                IsEnabled = true
            });

        }

        public ICommand ItemSelectedCommand => new Command<MasterViewMenuItem>(OnSelectItem, (item) => item.IsEnabled);
        private async void OnSelectItem(MasterViewMenuItem item)
        {
            if (item.IsEnabled)
            {
                object parameter = null;
                NavigationService.ClearStack();
                await NavigationService.NavigateToAsync(item.ViewModelType, parameter);
            }
        }

        private async void OnLogout()
        {
            //TODO Borrar las credenciales del usuario

            await NavigationService.NavigateToAsync<LoginViewModel>();
        }
    }
}
