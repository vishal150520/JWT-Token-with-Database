using System.ComponentModel.DataAnnotations;

namespace InventoryService.Models
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? UserName { get; set; }
        public String? Email { get; set; }
        public String? Password { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
