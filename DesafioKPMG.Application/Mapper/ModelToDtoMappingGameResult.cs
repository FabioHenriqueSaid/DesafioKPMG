using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;


namespace DesafioKPMG.Application.Mapper
{
    public class ModelToDtoMappingGameResult : Profile
    {
        public ModelToDtoMappingGameResult()
        {
            GameResultDtoMap();
        }
        private void GameResultDtoMap()
        {
            CreateMap<GameResult, GameResultDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
                .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(x => x.PlayerId))
                .ForMember(dest => dest.Win, opt => opt.MapFrom(x => x.Win))
                .ForMember(dest => dest.GameId, opt => opt.MapFrom(x => x.GameId))
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(x => x.TimeStamp));
        }
    }
}