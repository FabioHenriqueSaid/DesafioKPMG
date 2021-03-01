using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Domain.Core.Interfaces.Services;
using System.Collections.Generic;

namespace DesafioKPMG.Domain.Services
{
    public class Service<TEntity> : IService<TEntity>  where TEntity : class
    {
        private readonly IRepository<TEntity> repository;

        public Service(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            repository.Add(entity);
        }

        public IEnumerable<TEntity> ValidaBalancoPontos(long id)
        {
            return repository.ValidaBalancoPontos(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }
        public TEntity GetById(int playerid)
        {
            return repository.GetById(playerid);
        }

        public IEnumerable<TEntity> BestPlayers()
        {
            return repository.BestPlayers();
        }
    }
}
