using Lanches.Domain.Interfaces.Services;
using Lanches.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Lanches.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public TEntity FindById(int id)
        {
            return _repositoryBase.FindById(id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _repositoryBase.FindAll();
        }

    }
}
