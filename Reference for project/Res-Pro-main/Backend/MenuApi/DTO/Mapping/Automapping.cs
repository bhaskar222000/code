using AutoMapper;
using Menu_MS.DTO.FoodList;
using Menu_MS.DTO.Search;
using Menu_MS.Models;

namespace Menu_MS.DTO.Mapping
{
    public class Automapping:Profile
    {
        public Automapping()
        {
            CreateMap<FoodList01, Fooddot>().ReverseMap();
            CreateMap<FoodList01,Searchdto>().ReverseMap();
        }
    }
}
