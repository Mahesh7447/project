using Ecomm_Application.Models;
using Ecomm_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IUserRoleService userRoleService;

        public UserRoleController(IUserRoleService userRoleService)
        {
            this.userRoleService = userRoleService;
        }
        [HttpPost("assignrole")]
        public ActionResult<string> AssignRoleToUser(UserRole userRole)
        {
            if (userRole != null)
            {
               var status=userRoleService.AssingRoleToUser(userRole);
                if (status)
                {
                    return "Role Assigned Successfully";
                }
                else
                    return "Something went wrong";
            }
            return null;
        }
    }
}
