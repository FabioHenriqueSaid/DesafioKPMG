using System.Collections.Generic;

namespace DesafioKPMG.Domain.Core.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int playerid);
        IEnumerable<TEntity> ValidaBalancoPontos(long id);
        IEnumerable<TEntity> BestPlayers();
    }
}