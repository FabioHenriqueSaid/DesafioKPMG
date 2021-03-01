using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioKPMG.Application
{
    public class ApplicationServiceLeaderboard : IApplicationServiceLeaderboard
    {
        private readonly ILeaderboardService leaderboardService;
        private readonly IMapper mapper;
        public ApplicationServiceLeaderboard()
        {

        }
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

        public IEnumerable<LeaderboardDto> ValidaBalancoPontos(long id)
        {
            var leaderboard = leaderboardService.ValidaBalancoPontos(id);
            var leaderboardDto = mapper.Map<IEnumerable<LeaderboardDto>>(leaderboard);

            return leaderboardDto;
        }

        public LeaderboardDto GetById(int id)
        {
            var leaderboard = leaderboardService.GetById(id);
            var leaderboardDto = mapper.Map<LeaderboardDto>(leaderboard);

            return leaderboardDto;
        }

        public IEnumerable<LeaderboardDto> BestPlayers()
        {
            var leaderboard = leaderboardService.BestPlayers();
            var leaderboardtDto = mapper.Map<IEnumerable<LeaderboardDto>>(leaderboard);
            return leaderboardtDto;
        }

        public IEnumerable<LeaderboardDto> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
