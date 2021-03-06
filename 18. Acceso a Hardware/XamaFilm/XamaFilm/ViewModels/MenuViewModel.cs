﻿using System;
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

        private readonly IAuthenticationService _authenticationService;
        public MenuViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
            InitMenuItems();
        }
       
        private void InitMenuItems()
        {         
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Home,
                MenuItemType = MenuItemType.Home,
                ViewModelType = typeof(HomeViewModel),
                IsEnabled = true
            });            
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Movies,
                MenuItemType = MenuItemType.Movies,
                ViewModelType = typeof(MoviesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Series,
                MenuItemType = MenuItemType.Series,
                ViewModelType = typeof(SeriesListViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Favorites,
                MenuItemType = MenuItemType.Favorites,
                ViewModelType = typeof(FavoritesViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Watchlist,
                MenuItemType = MenuItemType.Watchlist,
                ViewModelType = typeof(WatchlistViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Settings,
                MenuItemType = MenuItemType.Settings,
                ViewModelType = typeof(SettingsViewModel),
                IsEnabled = true
            });
            MenuItems.Add(new MasterViewMenuItem
            {
                Title = Strings.AppResources.Logout,
                MenuItemType = MenuItemType.Logout,
                ViewModelType = typeof(LoginViewModel),
                IsEnabled = true,
                AfterNavigationAction = RemoveUserCredentials
            });

        }

        private Task RemoveUserCredentials()
        {
            return _authenticationService.LogoutAsync();
        }

        public ICommand ItemSelectedCommand => new Command<MasterViewMenuItem>(OnSelectItem, (item) => item.IsEnabled);
        private async void OnSelectItem(MasterViewMenuItem item)
        {
            if (item.IsEnabled)
            {
                object parameter = null;
                item.AfterNavigationAction?.Invoke();
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
