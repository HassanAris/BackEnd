using AutoMapper;
using BackEnd.Models;

namespace BackEnd.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile() {
            CreateMap<Livro, LivroDTO>().ReverseMap();  
        }
    }
}
