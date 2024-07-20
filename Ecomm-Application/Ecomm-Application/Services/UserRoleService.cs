using Ecomm_Application.Models;
using Ecomm_Application.Repositories;

namespace Ecomm_Application.Services
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleService(IUserRoleRepository userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }
        public bool AssingRoleToUser(UserRole userRole)
        {
            return userRoleRepository.AssingRoleToUser(userRole);
        }
    }
}
