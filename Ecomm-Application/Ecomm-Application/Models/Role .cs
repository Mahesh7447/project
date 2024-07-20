using System.ComponentModel.DataAnnotations;

namespace Ecomm_Application.Models
{
    public class Role
    {
        [Key]
        public int  RoleId { get; set; }
        [Required]
        public string  RoleName { get; set; }
    }
}
