using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Application.Interfaces
{
    public interface IIngredienteAppService : IAppServiceBase<Ingrediente>
    {
        new IEnumerable<Ingrediente> FindAll();
        new Ingrediente FindById(int Id);
    }
}
