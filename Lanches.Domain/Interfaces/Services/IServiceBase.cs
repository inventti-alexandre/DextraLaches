using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches.Domain.Interfaces.Services
{
    //Interface Base de Service
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> FindAll();
        TEntity FindById(int Id);
    }
}
