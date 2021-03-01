using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioKPMG.Infra.Data.Repositorys
{
    public class LeaderboardRepository : Repository<Leaderboard>, ILeaderboardRepository
    {
        private readonly DataContext dataContext;
        public LeaderboardRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }
        public IEnumerable<Leaderboard> ValidaBalancoPontos(long id)
        {
            return dataContext.Leaderboards.Where(p => p.PlayerId == id);
        }
        public IEnumerable<Leaderboard> BestPlayers()
        {
            return dataContext.Set<Leaderboard>().OrderByDescending(c => c.Balance);
        }

        public Task<Leaderboard> GetAllById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
