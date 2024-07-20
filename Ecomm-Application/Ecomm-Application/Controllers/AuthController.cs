using Ecomm_Application.Helpers;
using Ecomm_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }
        [HttpPost("login")]
        public ActionResult<string> Login(AuthRequest request)
        {
            if (request != null)
            {
                return authService.Login(request);
            }
            return null;
        }
    }
}
