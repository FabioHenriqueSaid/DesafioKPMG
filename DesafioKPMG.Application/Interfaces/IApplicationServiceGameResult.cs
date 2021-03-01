using DesafioKPMG.Application.Dtos;
using System.Collections.Generic;

namespace DesafioKPMG.Application.Interfaces
{
    public interface IApplicationServiceGameResult
    {
        void Add(GameResultDto gameResultDto);
        IEnumerable<GameResultDto> GetAll();
        GameResultDto GetById(int id);
        IEnumerable<GameResultDto> ValidaBalancoPontos(long id);
        IEnumerable<LeaderboardDto> BestPlayers();
    }
}
