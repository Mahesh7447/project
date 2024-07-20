using Ecomm_Application.Models;

namespace Ecomm_Application.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRoleRepository(ApplicationDbContext dbContext)
        { 
            this.dbContext = dbContext;
        }
        public bool AssingRoleToUser(UserRole userRole)
        {
            if (userRole != null)
            {
                dbContext.userRoles.Add(userRole);
                dbContext.SaveChanges();
                return true;
            }
            return false;
            
        }
    }
}
