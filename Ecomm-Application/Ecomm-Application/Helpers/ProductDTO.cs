using System.ComponentModel.DataAnnotations;

namespace Ecomm_Application.Helpers
{
    public class ProductDTO
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductQuantity { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public string ProductImage { get; set; }
    }
}
