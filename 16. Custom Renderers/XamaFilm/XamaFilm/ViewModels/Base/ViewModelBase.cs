using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Services;
using Xamarin.Forms;

namespace XamaFilm.ViewModels.Base
{
    public class ViewModelBase : BindableObject
    {                
        protected readonly INavigationService NavigationService;
        public ViewModelBase()
        {
            NavigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(false);
        }

        public virtual void OnAppearing()
        {
            
        }
    }
}
