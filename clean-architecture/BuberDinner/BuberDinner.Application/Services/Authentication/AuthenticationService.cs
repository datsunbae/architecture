using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService() { }

        public async Task<AuthenticationResult> Login(string email, string password)
        {
            return await Task.FromResult(new AuthenticationResult(Guid.Empty, "firstName", "lastName", email, "accessToken"));
        }

        public async Task<AuthenticationResult> Register(string firstName, string lastName, string email)
        {
            return await Task.FromResult(new AuthenticationResult(Guid.NewGuid(), firstName, lastName, email, "accessToken"));
        }
    }
}
