using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using XamaFilm.Views;
using Xamarin.Forms;

namespace XamaFilm.Models
{

    public class MasterViewMenuItem : BindableObject
    {
        private string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private MenuItemType _menuItemType;
        public MenuItemType MenuItemType
        {
            get => _menuItemType;
            set
            {
                _menuItemType = value;
                OnPropertyChanged();
            }
        }

        private Type _viewModelType;

        public Type ViewModelType
        {
            get => _viewModelType;
            set
            {
                _viewModelType = value;
                OnPropertyChanged();
            }
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }
    }
}