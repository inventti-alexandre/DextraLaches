using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Domain.Interfaces.Repositories
{
    public interface IPromocaoRepository : IRepositoryBase<Promocao>
    {
        new IEnumerable<Promocao> FindAll();
        new Promocao FindById(int Id);
    }
}
