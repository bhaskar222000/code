using System.ComponentModel.DataAnnotations;

namespace Admin_user_MS.Models
{
    public class AdminUser
    {
        [Key]
        public int UserId { get;set; }
        [Required]
        public string UserName { get;set; }
        [Required]  
        public string Password { get;set; }
        [Required]  
        public string Role { get; set; }
        [Required]  
        public string Email { get;set; }
       
    }
}
