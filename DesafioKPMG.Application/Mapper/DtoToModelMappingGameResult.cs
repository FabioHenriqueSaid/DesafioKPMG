using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioKPMG.Application.Mapper
{
    public class DtoToModelMappingGameResult : Profile
    {
        public DtoToModelMappingGameResult()
        {
            GameResultMap();
        }
        private void GameResultMap()
        {
            CreateMap<GameResultDto, GameResult>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.GameId, opt => opt.MapFrom(x => x.GameId))
                .ForMember(dest => dest.PlayerId, opt => opt.MapFrom(x => x.PlayerId))
                .ForMember(dest => dest.TimeStamp, opt => opt.MapFrom(x => x.TimeStamp))
                .ForMember(dest => dest.Win, opt => opt.MapFrom(x => x.Win));
        }
    }
}
