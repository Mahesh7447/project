using Ecomm_Application.Models;

namespace Ecomm_Application.Repositories
{
    public interface IUserRepository
    {
        public List<User> GetUsers();
        public User GetUser(int id);
        public User SaveUser(User user);
        public bool DeleteUser(int id);
        public Role SaveRole(Role role);    
    }
}
