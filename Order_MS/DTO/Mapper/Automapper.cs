using AutoMapper;
using Order_MS.DTO.Orderdot;
using Order_MS.DTO.Ratingdot;
using Order_MS.Models;

namespace Order_MS.DTO.Mapper
{
    public class Automapper:Profile
    {
        public Automapper()
        {
            CreateMap<OrderList,orderdot>().ReverseMap();
            CreateMap<Rating,ratingdot>().ReverseMap();
        }
    }
}
