using DesafioKPMG.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioKPMG.Application.Interfaces
{
    public interface IApplicationServiceLeaderboard
    {
        void Add(LeaderboardDto leaderboardDto);
        IEnumerable<LeaderboardDto> GetAll();
        LeaderboardDto GetById(int id);
        IEnumerable<LeaderboardDto> ValidaBalancoPontos(long id);

        IEnumerable<LeaderboardDto> BestPlayers();
    }
}