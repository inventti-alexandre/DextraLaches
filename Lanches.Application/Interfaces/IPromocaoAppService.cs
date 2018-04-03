using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Application.Interfaces
{
    public interface IPromocaoAppService : IAppServiceBase<Promocao>
    {
        new IEnumerable<Promocao> FindAll();
        new Promocao FindById(int Id);
    }
}
