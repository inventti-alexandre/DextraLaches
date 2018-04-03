using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Application.Interfaces
{
    public interface ILancheAppService : IAppServiceBase<Lanche>
    {
        new IEnumerable<Lanche> FindAll();
        new Lanche FindById(int Id);

        //Método para regra da Aplicação.
        decimal CalculaPrecoLanche(Lanche lanche);
    }
}
