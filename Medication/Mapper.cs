
using AutoMapper;
using DTO;
using Entites;

namespace Medication
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<SystemMessage, SystemMessageDTO>().ReverseMap();
        }
    }
}
