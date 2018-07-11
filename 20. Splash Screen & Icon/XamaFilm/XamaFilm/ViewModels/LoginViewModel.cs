using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using XamaFilm.Services;
using Xamarin.Forms;

namespace XamaFilm.ViewModels
{
    public class LoginViewModel : Base.ViewModelBase
    {
        private readonly IAuthenticationService _authenticationService;
        public LoginViewModel(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public ICommand SignInCommand => new Command(SignInAsync);

        private string _userName;
        public string UserName
        {
            get => _userName;
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        private async void SignInAsync()
        {
            await _authenticationService.LoginAsync(UserName, Password);
            if(_authenticationService.IsAuthenticated)
                await NavigationService.NavigateToAsync<MasterViewModel>();
        }
    }
}
