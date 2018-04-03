using Lanches.Domain.Entities;
using Lanches.Application.Interfaces;
using System.Collections.Generic;
using Lanches.Domain.Interfaces.Services;

namespace Lanches.Application.Services
{
    public class PromocaoAppService : AppServiceBase<Promocao>, IPromocaoAppService
    {
        private readonly IPromocaoService _promocaoService;

        public PromocaoAppService(IPromocaoService promocaoService) : base(promocaoService)
        {
            _promocaoService = promocaoService;
        }

        public new IEnumerable<Promocao> FindAll()
        {
            return _promocaoService.FindAll();
        }

        public new Promocao FindById(int Id)
        {
            return _promocaoService.FindById(Id);
        }
    }
}
