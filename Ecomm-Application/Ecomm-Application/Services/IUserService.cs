using Ecomm_Application.Models;

namespace Ecomm_Application.Services
{
    public interface IUserService
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public User SaveUser(User user);
        public bool DeleteUser(int id);
        public Role SaveRole(Role role);
    }
}
