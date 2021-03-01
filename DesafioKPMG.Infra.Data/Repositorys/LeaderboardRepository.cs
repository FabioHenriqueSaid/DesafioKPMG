using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Context;
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

        public Task<Leaderboard> GetAllById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
