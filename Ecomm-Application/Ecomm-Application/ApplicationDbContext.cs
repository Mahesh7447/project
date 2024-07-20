using Ecomm_Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecomm_Application
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> products { get; set; }
    }
}
