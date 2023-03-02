
using AutoMapper;

namespace DTO
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
        
    }
}
