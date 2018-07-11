using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamaFilm.Models;

namespace XamaFilm.Services
{
    public interface IAuthenticationService
    {
        bool IsAuthenticated { get; }

        string AuthenticatedUser { get; }

        Task<bool> LoginAsync(string email, string password);

        Task LogoutAsync();
    }
}
