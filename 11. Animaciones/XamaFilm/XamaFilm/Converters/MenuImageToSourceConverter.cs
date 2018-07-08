using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using XamaFilm.Models;
using Xamarin.Forms;

namespace XamaFilm.Converters
{
    public class MenuImageToSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var menu = (MenuItemType)value;
            switch(menu)
            {
                case MenuItemType.Home: return "home_menu.png";
                case MenuItemType.Movies: return "movie_menu.png";
                case MenuItemType.Series: return "serie_menu.png";
                case MenuItemType.Favorites: return "favorites_menu.png";
                case MenuItemType.Watchlist: return "watchlist_menu.png";
                case MenuItemType.Settings: return "settings_menu.png";
            }
            return "home.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
