using Ecomm_Application.Models;
using Ecomm_Application.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(userService.GetUsers());
        }
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            if (id <= 0)
                return BadRequest();
            return Ok(userService.GetUser(id));
        }
        [HttpPost("save")]
        public ActionResult<User> SaveUser(User user)
        {
            if (user != null)
            {
                var user1 = userService.SaveUser(user);
                if (user1 != null)
                {
                    return Ok(user1);
                }
                else
                    return BadRequest();
            }
            return null;
        }

        [HttpDelete("delete/{id}")]
        public ActionResult<bool> DeleteUser(int id)
        {
            if (id <= 0)
                return BadRequest();
            var status=userService.DeleteUser(id);
            if (status)
            {
                return status;
            }
            else
                return NotFound();
        }
        [HttpPost("role")]
        public ActionResult<Role> SaveRole(Role role)
        {
            if (role != null)
            {
                return userService.SaveRole(role);
            }
            return null;
        }

    }
}
