using Scoreboard.Application.Features.Games.Queries.GetGamesQuery;
using Scoreboard.Domain.Entities;
using AutoMapper;
using System.Globalization;

namespace Scoreboard.Application.Mappings
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Game, GamesVm>().ReverseMap();
            CreateMap<Game, GamesVm>().ForMember(dest => dest.HomeTeamName, opt => opt.MapFrom(src => src.HomeTeam.Name));
            CreateMap<Game, GamesVm>().ForMember(dest => dest.VisitatorTeamName, opt => opt.MapFrom(src => src.VisitatorTeam.Name));
            CreateMap<Game, GamesVm>().ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString("MM/dd/yyyy")));
        }
    }
}
