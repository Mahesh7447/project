using Ecomm_Application.Helpers;

namespace Ecomm_Application.Services
{
    public interface IProductService
    {
        public IEnumerable<ProductDTO> GetProducts();
        public ProductDTO GetProduct(int id);
        public ProductDTO SaveProduct(ProductDTO product);
        public bool DeleteProduct(int id);
    }
}
