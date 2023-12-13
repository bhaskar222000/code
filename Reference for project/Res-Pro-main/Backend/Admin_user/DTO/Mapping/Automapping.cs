using Admin_user_MS.DTO.Registration;
using Admin_user_MS.Models;
using AutoMapper;

namespace Admin_user_MS.DTO.Mapping
{
    public class Automapping:Profile
    {
        public Automapping()
        {
            CreateMap<AdminUser, Registrationdto>().ReverseMap(); 
        }
    }
}
