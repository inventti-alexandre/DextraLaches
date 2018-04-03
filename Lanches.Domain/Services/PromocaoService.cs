using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Repositories;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Domain.Services
{
    public class PromocaoService : ServiceBase<Promocao>, IPromocaoService
    {
        private readonly IPromocaoRepository _promocaoRepository;

        public PromocaoService(IPromocaoRepository promocaoRepository) : base(promocaoRepository)
        {
            _promocaoRepository = promocaoRepository;
        }

        public new IEnumerable<Promocao> FindAll()
        {
            return _promocaoRepository.FindAll();
        }

        public new Promocao FindById(int Id)
        {
            return _promocaoRepository.FindById(Id);
        }
    }
}
