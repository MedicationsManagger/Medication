
using AutoMapper;
using DTO;

namespace Medication
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
