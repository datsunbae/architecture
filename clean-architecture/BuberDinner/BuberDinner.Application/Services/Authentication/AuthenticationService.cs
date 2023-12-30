using BuberDinner.Application.Common.Interfaces.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator) 
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public async Task<AuthenticationResult> Login(string email, string password)
        {
            return 
                await Task.FromResult
                    (new AuthenticationResult
                        (Guid.Empty,
                         "firstName",
                         "lastName",
                         email,
                         "accessToken"));
        }

        public async Task<AuthenticationResult> Register(string firstName, string lastName, string email)
        {
            var userId = Guid.NewGuid();
            var accessToken = _jwtTokenGenerator.GenerateToken(userId, firstName, lastName);

            return 
                await Task.FromResult
                    (new AuthenticationResult(
                        userId, 
                        firstName, 
                        lastName, 
                        email,
                        accessToken)
                    );
        }
    }
}
