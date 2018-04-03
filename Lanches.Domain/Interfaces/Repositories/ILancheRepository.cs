using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Domain.Interfaces.Repositories
{
    public interface ILancheRepository : IRepositoryBase<Lanche>
    {
        new IEnumerable<Lanche> FindAll();
        new Lanche FindById(int Id);
    }
}
