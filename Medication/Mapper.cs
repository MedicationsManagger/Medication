
using AutoMapper;
using DTO;
using Entites;

namespace Medication
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<User, UserDTO>().ForMember(dest => dest.GenderId, opts => opts.MapFrom(src => src.Gender.Id)).ReverseMap();
            CreateMap<SystemMessage, SystemMessageDTO>().ForMember(dest => dest.UserId, opts => opts.MapFrom(src => src.User.Id)).ReverseMap();
            CreateMap<MedicineStock, MedicineStockDTO>().ForMember(dest => dest.MedicineId, opts => opts.MapFrom(src => src.Medicine.Id)).ReverseMap();
        }
    }
}
