using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;
using System.Collections.Generic;

namespace DesafioKPMG.CrossCutting.Mapper
{
    public interface IMapperGameResult
    {
        GameResult MapperDtoToEntity(GameResultDto gameResultDto);
        IEnumerable<GameResultDto> MapperListGameResultsDto(IEnumerable<GameResult> gameResults);
        GameResultDto MapperEntityToDto(GameResult gameResult);
    }
}