using Pri.Ee.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Services.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> RegisterAsync(RegisterUserDto registerUserDto);
        Task<AuthenticationResponse> LoginAsync(LoginUserDto loginUserDto);
        bool Logout();
    }
}
