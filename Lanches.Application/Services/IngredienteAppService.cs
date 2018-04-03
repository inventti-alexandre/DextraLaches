using Lanches.Application.Interfaces;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Application.Services
{
    public class IngredienteAppService : AppServiceBase<Ingrediente>, IIngredienteAppService
    {
        private readonly IIngredienteService _ingredienteService;

        public IngredienteAppService(IIngredienteService ingredienteService) : base(ingredienteService)
        {
            _ingredienteService = ingredienteService;
        }

        public new IEnumerable<Ingrediente> FindAll()
        {
            return _ingredienteService.FindAll();
        }

        public new Ingrediente FindById(int Id)
        {
            return _ingredienteService.FindById(Id);
        }
    }
}
