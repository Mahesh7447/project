using System.ComponentModel.DataAnnotations;

namespace Ecomm_Application.Helpers
{
    public class AuthRequest
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }    
    }
}
