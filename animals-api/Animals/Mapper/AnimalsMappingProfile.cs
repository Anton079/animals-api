using animals_api.Animals.Dtos;
using animals_api.Animals.Models;
using AutoMapper;

namespace animals_api.Animals.Mapper
{
    public class AnimalsMappingProfile : Profile
    {
        public AnimalsMappingProfile()
        {
            CreateMap<AnimalRequest, Animal>();
            CreateMap<Animal, AnimalRequest>();
        }
    }
}
