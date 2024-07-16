using Microsoft.AspNetCore.Authentication;

namespace Lucky.WebAPI.Service.Contract
{
    public interface IServiceManager
    {
        IAuthenticationService AuthenticationService { get; }
    }
}
