using Ecomm_Application.Models;

using Ecomm_Application.Repositories;

namespace Ecomm_Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public bool DeleteProduct(int id)
        {
            return this.productRepository.DeleteProduct(id);
        }

        public Product GetProduct(int id)
        {
            return this.productRepository.GetProduct(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.productRepository.GetProducts();
        }

        public Product SaveProduct(Product product)
        {
            return this.productRepository.SaveProduct(product);
        }
    }
}
