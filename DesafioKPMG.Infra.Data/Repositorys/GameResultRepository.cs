using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Entities;
using DesafioKPMG.Infra.Data.Context;
using System.Threading.Tasks;

namespace DesafioKPMG.Infra.Data.Repositorys
{
    public class GameResultRepository : Repository<GameResult>, IGameResultRepository
    {
        private readonly DataContext dataContext;
        public GameResultRepository(DataContext dataContext) : base(dataContext)
        {
            this.dataContext = dataContext;
        }

        public Task<GameResult> GetAllById(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
