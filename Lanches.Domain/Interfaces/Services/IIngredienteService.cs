using System.Collections.Generic;
using Lanches.Domain.Entities;

namespace Lanches.Domain.Interfaces.Services
{
    //Interface de Service para Ingrediente.
    public interface IIngredienteService : IServiceBase<Ingrediente>
    {
        new IEnumerable<Ingrediente> FindAll();
        new Ingrediente FindById(int Id);
    }
}
