using Lanches.Domain.Entities;
using System.Collections.Generic;

namespace Lanches.Domain.Interfaces.Repositories
{
    //Interface de Repositorio para Ingrediente.
    public interface IIngredienteRepository : IRepositoryBase<Ingrediente>
    {
        new IEnumerable<Ingrediente> FindAll();
        new Ingrediente FindById(int Id);
    }
}
