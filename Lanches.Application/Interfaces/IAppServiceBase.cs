using System.Collections.Generic;

namespace Lanches.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();
        TEntity FindById(int Id);
    }
}
