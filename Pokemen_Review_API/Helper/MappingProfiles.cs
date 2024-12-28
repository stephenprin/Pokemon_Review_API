using AutoMapper;
using Pokemen_Review_API.Dto;
using Pokemen_Review_API.Models;

namespace Pokemen_Review_API.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();
            CreateMap<Owner, OwnerDto>();
        }
    }
}
