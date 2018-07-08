using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;
using Xamarin.Essentials;

namespace XamaFilm.Services
{
    public class MockAuthenticationService : IAuthenticationService
    {
        private readonly string UserKey = "UserKey";
        private readonly string IsAuthenticatedKey = "IsAuthenticatedKey";

        public MockAuthenticationService()
        {
            IsAuthenticated = Preferences.Get("IsAuthenticatedKey", false);
            AuthenticatedUser = Preferences.Get(UserKey, "");
        }

        public bool IsAuthenticated { get; set; }
        
        public string AuthenticatedUser { get; set; }

        public async Task<bool> LoginAsync(string user, string password)
        {
            IsAuthenticated = true;

            AuthenticatedUser = user;
            Preferences.Set(UserKey, user);
            Preferences.Set(IsAuthenticatedKey, true);

            return await Task.FromResult(true);
        }

        public async Task LogoutAsync()
        {
            IsAuthenticated = false;
            AuthenticatedUser = null;

            Preferences.Remove(IsAuthenticatedKey);
        }
    }
}
