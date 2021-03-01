using DesafioKPMG.Domain.Core.Interfaces.Repository;
using DesafioKPMG.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace DesafioKPMG.Infra.Data.Repositorys
{
    public class Repository<TEntity> : IRepository <TEntity> where TEntity: class
    {
        private readonly DataContext dataContext;
        public Repository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void Add(TEntity entity)
        {
            try
            {
                dataContext.Set<TEntity>().Add(entity);
                dataContext.SaveChanges();
            }
            catch (System.Exception ex)
            {
                throw ex; 
            }
        }

        public IEnumerable<TEntity> ValidaBalancoPontos(long id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dataContext.Set<TEntity>().ToList();
        }
        public TEntity GetById(int id)
        {
            return dataContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> BestPlayers()
        {
            return dataContext.Set<TEntity>().ToList();
        }
    }
}
