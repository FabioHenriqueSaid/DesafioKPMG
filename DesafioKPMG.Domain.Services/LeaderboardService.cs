using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DesafioKPMG.Domain.Services
{
    public class LeaderboardService : Service<Leaderboard>, ILeaderboardService
    {
        private readonly ILeaderboardRepository leaderboardRepository;

        public LeaderboardService(ILeaderboardRepository leaderboardRepository) : base(leaderboardRepository)
        {
            this.leaderboardRepository = leaderboardRepository;
        }

    }
}