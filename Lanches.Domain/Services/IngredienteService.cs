using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Repositories;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Domain.Services
{
    public class IngredienteService : ServiceBase<Ingrediente>, IIngredienteService
    {
        private readonly IIngredienteRepository _ingredienteRepository;

        public IngredienteService(IIngredienteRepository ingredienteRepository) : base(ingredienteRepository)
        {
            _ingredienteRepository = ingredienteRepository;
        }

        public new IEnumerable<Ingrediente> FindAll()
        {
            return _ingredienteRepository.FindAll();
        }

        public new Ingrediente FindById(int Id)
        {
            return _ingredienteRepository.FindById(Id);
        }
    }
}
