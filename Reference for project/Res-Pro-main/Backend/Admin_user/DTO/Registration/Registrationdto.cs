using System.ComponentModel.DataAnnotations;

namespace Admin_user_MS.DTO.Registration
{
    public class Registrationdto
    {
       
        public string UserName { get; set; }
        
        public string Password { get; set; }
       
        public string Role { get; set; }
       
        public string Email { get; set; }
    }
}
