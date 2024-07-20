using Ecomm_Application.Models;

namespace Ecomm_Application.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteUser(int id)
        {
            var user = dbContext.users.FirstOrDefault(user => user.UserId == id);
            if (user != null)
            {
                dbContext.Remove(user);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public User GetUser(int id)
        {
            return dbContext.users.FirstOrDefault(user => user.UserId == id);
        }

        public List<User> GetUsers()
        {
            return dbContext.users.ToList();
        }

        public User SaveUser(User user)
        {
            if (user != null)
            {
                dbContext.users.Add(user);
                dbContext.SaveChanges();
                return user;
            }
            return null;
        }
        public Role SaveRole(Role role)
        {
            if (role != null)
            {
                dbContext.roles.Add(role);
                dbContext.SaveChanges();
                return role;

            }
            return null;
        }
    }
}
