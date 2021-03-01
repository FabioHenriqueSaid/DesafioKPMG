using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;

namespace DesafioKPMG.Application.Mapper
{
    public class DtoToModelMappingLeaderboard : Profile
    {
        public DtoToModelMappingLeaderboard()
        {
            LeaderboardMap();
        }
        private void LeaderboardMap()
        {
            CreateMap<LeaderboardDto, Leaderboard>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(x => x.PlayerId))
                .ForMember(dest => dest.LastUpdateDate, opt => opt.MapFrom(x => x.LastUpdateDate))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(x => x.Balance));
        }
    }
}
