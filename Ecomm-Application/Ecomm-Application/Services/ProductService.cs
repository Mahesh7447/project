using Ecomm_Application.Helpers;
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

        public ProductDTO SaveProduct(ProductDTO product)
        {
            ProductDTO dto = new ProductDTO();
            if (product != null)
            {
                dto=ToDTO(this.productRepository.SaveProduct(ToEntity(product)));
                return dto;
            }
                return null;
        }

        public ProductDTO GetProduct(int id)
        {
            return ToDTO(this.productRepository.GetProduct(id));
        }

        IEnumerable<ProductDTO> IProductService.GetProducts()
        {
            return this.productRepository.GetProducts().Select(product => ToDTO(product));
        }
        public static Product ToEntity(ProductDTO product)
        {
            Product prod = new Product();
            if (product != null)
            {
                prod.ProductName = product.ProductName;
                prod.ProductQuantity = product.ProductQuantity;
                prod.ProductDescription = product.ProductDescription;
                prod.ProductPrice = product.ProductPrice;
                prod.ProductImage = product.ProductImage;
            }
            return prod;
        }
        public static ProductDTO ToDTO(Product product)
        {
            if (product != null)
            {
                ProductDTO dto = new ProductDTO();
                dto.ProductName = product.ProductName;
                dto.ProductQuantity = product.ProductQuantity;
                dto.ProductDescription = product.ProductDescription;
                dto.ProductPrice = product.ProductPrice;
                dto.ProductImage = product.ProductImage;
                return dto;
            }
            return null;
        }
    }
}
