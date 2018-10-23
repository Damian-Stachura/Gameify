using AutoMapper;
using Gameify.Dtos;
using Gamey.Models;

namespace Gameify
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Game, GameDto>()
                .ReverseMap();
            CreateMap<Genre, GenreDto>()
                .ReverseMap();
            CreateMap<PegiAge, PegiAgeDto>()
                .ReverseMap();
            CreateMap<PegiContent, PegiContentDto>()
                .ReverseMap();
        }
    }
}
