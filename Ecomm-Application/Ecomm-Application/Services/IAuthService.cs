using Ecomm_Application.Helpers;

namespace Ecomm_Application.Services
{
    public interface IAuthService
    {
        public string Login(AuthRequest request);
    }
}
