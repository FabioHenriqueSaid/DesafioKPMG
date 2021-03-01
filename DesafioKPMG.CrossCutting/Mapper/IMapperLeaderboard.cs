using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Domain.Entities;
using System.Collections.Generic;

namespace DesafioKPMG.CrossCutting.Mapper
{
    public interface IMapperLeaderboard
    {
        Leaderboard MapperDtoToEntity(LeaderboardDto leaderboardDto);
        IEnumerable<LeaderboardDto> MapperListGameResultsDto(IEnumerable<Leaderboard> leaderboards);
        LeaderboardDto MapperEntityToDto(Leaderboard leaderboard);
    }
}