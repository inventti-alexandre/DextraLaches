using Lanches.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace Lanches.Infraestructure.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        //protected DBcontext dBcontext = new DBcontext();

        public IEnumerable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
