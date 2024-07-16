using AutoMapper;
using Lucky.WebAPI.Data.Models;
using Lucky.WebAPI.DataTransferObjects;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lucky.WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, LuckyUser>();
        }
    }
}
