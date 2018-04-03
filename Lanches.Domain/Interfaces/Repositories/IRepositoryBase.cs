using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();
        TEntity FindById(int Id);
    }
}
