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
        private bool existePlayer;
        public ApplicationServiceGameResult(IGameResultService gameResultService
                                       , IMapper mapper, ILeaderboardService leaderboardService
            )
        {
            this.gameResultService = gameResultService;
            this.mapper = mapper;
            this.leaderboardService = leaderboardService;
        }

        public void Add(GameResultDto gameResultDto)
        {
            var gameResult = mapper.Map<GameResult>(gameResultDto);
            gameResultService.Add(gameResult);

            //Valida se o Jogador já possui balanco de pontos
            ValidaBalancoPontos(gameResult.PlayerId);
            if (existePlayer == false)
            {
                Addleaderboard(gameResult.PlayerId, gameResult.Win);
            }
        }

        public void Addleaderboard(long playerId, long win)
        {
            Leaderboard leaderboard = new Leaderboard();
            leaderboard.PlayerId = playerId;
            leaderboard.Balance = win;
            leaderboard.LastUpdateDate = DateTime.Now;
            leaderboardService.Add(leaderboard);
        }

        public IEnumerable<LeaderboardDto> BestPlayers()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GameResultDto> GetAll()
        {
            var gameResult = gameResultService.GetAll();
            var gameResultDto = mapper.Map<IEnumerable<GameResultDto>>(gameResult);

            return gameResultDto;
        }

        public GameResultDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LeaderboardDto> ValidaBalancoPontos(long id)
        {
            var leaderboard = leaderboardService.ValidaBalancoPontos(id);
            var leaderboardDto = mapper.Map<IEnumerable<LeaderboardDto>>(leaderboard);
            foreach (var count in leaderboardDto)
            {
                existePlayer = true;
            }
            return leaderboardDto;
        }

        IEnumerable<GameResultDto> IApplicationServiceGameResult.ValidaBalancoPontos(long id)
        {
            throw new NotImplementedException();
        }
    }
}