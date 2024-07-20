using Ecomm_Application.Models;

namespace Ecomm_Application.Services
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();
        public Product GetProduct(int id);
        public Product SaveProduct(Product product);
        public bool DeleteProduct(int id);
    }
}
