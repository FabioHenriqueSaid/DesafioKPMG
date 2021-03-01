using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;

namespace DesafioKPMG.Application.Mapper
{
    public class ModelToDtoMappingLeaderboard : Profile
    {
        public ModelToDtoMappingLeaderboard()
        {
            LeaderboardDtoMap();
        }
        private void LeaderboardDtoMap()
        {
            CreateMap<Leaderboard, LeaderboardDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(x => x.PlayerId))
                .ForMember(dest => dest.Balance, opt => opt.MapFrom(x => x.Balance))
                .ForMember(dest => dest.LastUpdateDate, opt => opt.MapFrom(x => x.LastUpdateDate));
        }
    }
}
