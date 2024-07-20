using Ecomm_Application.Models;

namespace Ecomm_Application.Repositories
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProduct(int id);
        public Product SaveProduct(Product product);   
        public bool DeleteProduct(int id);
    }
}
