using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Domain.Interfaces.Services
{
    //Interface de Service para Lanche.
    public interface ILancheService : IServiceBase<Lanche>
    {
        new IEnumerable<Lanche> FindAll();
        new Lanche FindById(int Id);
    }
}
