using Ecomm_Application.Models;
using System.Resources;

namespace Ecomm_Application.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext dbContext;

        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool DeleteProduct(int id)
        {
            var product = dbContext.products.FirstOrDefault(product => product.ProductId == id);
            if (product != null)
            {
                dbContext.products.Remove(product);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public Product GetProduct(int id)
        {
            var product=dbContext.products.FirstOrDefault(product => product.ProductId == id);
            if (product != null)
            {
                return product;
            }
            return null;
        }

        public IEnumerable<Product> GetProducts()
        {
            return dbContext.products.ToList();
        }

        public Product SaveProduct(Product product)
        {
            if (product != null)
            {
                dbContext.products.Add(product);
                dbContext.SaveChanges();
                return product;
            }
            return null;
        }
    }
}
