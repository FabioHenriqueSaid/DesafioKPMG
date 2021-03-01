using AutoMapper;
using DesafioKPMG.Application.Dtos;
using DesafioKPMG.Application.Interfaces;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DesafioKPMG.Application
{
    public class ApplicationServiceGameResult : IApplicationServiceGameResult
    {
        private readonly IGameResultService gameResultService;
        private readonly ILeaderboardService leaderboardService;
        private readonly ApplicationServiceLeaderboard applicationServiceLeaderboard;
        private readonly IMapper mapper;
        public ApplicationServiceGameResult(IGameResultService gameResultService
                                       , IMapper mapper, ILeaderboardService leaderboardService)
        {
            this.gameResultService = gameResultService;
            this.mapper = mapper;
            this.leaderboardService = leaderboardService;
        }

        public void Add(GameResultDto gameResultDto)
        {    
            var gameResult = mapper.Map<GameResult>(gameResultDto);
            gameResultService.Add(gameResult);
            applicationServiceLeaderboard.AddLeaderboard(gameResult.PlayerId, gameResult.Win);
        }
        public IEnumerable<GameResultDto> GetAll()
        {
            var gameResult = gameResultService.GetAll();
            var gameResultDto = mapper.Map<IEnumerable<GameResultDto>>(gameResult);

            return gameResultDto;
        }
    }
}