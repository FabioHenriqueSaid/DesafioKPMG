using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using DesafioKPMG.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioKPMG.Domain.Services
{
    public class GameResultService : Service<GameResult>, IGameResultService
    {
        private readonly IGameResultRepository gameResultRepository;

        public GameResultService(IGameResultRepository gameResultRepository):base(gameResultRepository)
        {
            this.gameResultRepository = gameResultRepository;
        }
    }
}
