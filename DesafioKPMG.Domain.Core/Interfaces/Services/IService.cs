using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioKPMG.Domain.Core.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int playerid);
        IEnumerable<TEntity> ValidaBalancoPontos(long id);
        IEnumerable<TEntity> BestPlayers();
    }
}
