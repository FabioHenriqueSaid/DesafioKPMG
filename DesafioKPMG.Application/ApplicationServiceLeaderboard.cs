using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace DesafioKPMG.Application
{
    public class ApplicationServiceLeaderboard : IApplicationServiceLeaderboard
    {
        private readonly ILeaderboardService leaderboardService;
        private readonly IMapper mapper;
        public ApplicationServiceLeaderboard(ILeaderboardService leaderboardService
                                       , IMapper mapper)
        {
            this.leaderboardService = leaderboardService;
            this.mapper = mapper;
        }

        public void Add(LeaderboardDto leaderboardDto)
        {
            var leaderboard = mapper.Map<Leaderboard>(leaderboardDto);
            leaderboardService.Add(leaderboard);
        }
        public void AddLeaderboard(long playerId, long balanceValue)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.PlayerId = playerId;
            leaderboard.Balance = balanceValue;
            leaderboard.LastUpdateDate = DateTime.Now;
            leaderboardService.Add(leaderboard);
        }

        public void Teste(DataContext dataContext) {

            IEnumerable<string> dataContextt = Leaderboard
                               .Where(n => n.Contains("a"))
                               .OrderBy(n => n.Length)
                               .Select(n => n.ToUpper());
        }
        public IEnumerable<LeaderboardDto> GetAll()
        {
            var leaderboard = leaderboardService.GetAll();
            var leaderboardtDto = mapper.Map<IEnumerable<LeaderboardDto>>(leaderboard);

            return leaderboardtDto;
        }
    }
}
