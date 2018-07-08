using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace XamaFilm.ViewModels
{
    public class MasterViewModel : Base.ViewModelBase
    {
        public MasterViewModel(MenuViewModel menuViewModel)
        {
            _menuViewModel = menuViewModel;
        }

        private MenuViewModel _menuViewModel;
        public MenuViewModel MenuViewModel
        {
            get => _menuViewModel;
            set
            {
                _menuViewModel = value;
                OnPropertyChanged();
            }
        }

        public async override Task InitializeAsync(object navigationData)
        {
            await _menuViewModel.InitializeAsync(navigationData);
            await NavigationService.NavigateToAsync<HomeViewModel>();
        }
    }
}
