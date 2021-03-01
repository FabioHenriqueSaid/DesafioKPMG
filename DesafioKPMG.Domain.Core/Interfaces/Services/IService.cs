using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesafioKPMG.Domain.Core.Interfaces.Services
{
    public interface IService<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        IEnumerable<TEntity> GetAll();
    }
}
