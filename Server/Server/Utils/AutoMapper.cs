using AutoMapper;
using Server.DTOs;
using Server.Models;

namespace Server.Utils
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Student, StudentDTO>().ReverseMap();
        }
    }
}
