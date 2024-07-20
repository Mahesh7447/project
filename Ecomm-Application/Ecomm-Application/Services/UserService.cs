using Ecomm_Application.Models;
using Ecomm_Application.Repositories;

namespace Ecomm_Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public bool DeleteUser(int id)
        {
            return this.userRepository.DeleteUser(id);  
        }

        public User GetUser(int id)
        {
            return this.userRepository.GetUser(id);
        }

        public List<User> GetUsers()
        {
            return this.userRepository.GetUsers();
        }

        public User SaveUser(User user)
        {
            return this.userRepository.SaveUser(user);
        }

        public Role SaveRole(Role role)
        {
            return this.userRepository.SaveRole(role);
        }
    }
}
