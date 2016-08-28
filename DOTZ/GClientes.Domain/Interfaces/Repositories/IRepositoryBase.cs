using GClientes.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GClientes.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity: EntityBase
    {

        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Remove(TEntity obj);

        void Dispose();
        
    }
}
