using Lanches.Application.Interfaces;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IAppServiceBase<TEntity> _serviceBase;
        private ILancheService lancheService;
        private IIngredienteService ingredienteService;
        private IPromocaoService promocaoService;

        public AppServiceBase(IAppServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public AppServiceBase(ILancheService lancheService)
        {
            this.lancheService = lancheService;
        }

        public AppServiceBase(IIngredienteService ingredienteService)
        {
            this.ingredienteService = ingredienteService;
        }

        public AppServiceBase(IPromocaoService promocaoService)
        {
            this.promocaoService = promocaoService;
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _serviceBase.FindAll();
        }

        public TEntity FindById(int Id)
        {
            return _serviceBase.FindById(Id);
        }
    }
}
