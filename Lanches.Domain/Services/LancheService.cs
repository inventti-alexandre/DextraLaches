using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Repositories;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Domain.Services
{
    public class LancheService : ServiceBase<Lanche>, ILancheService
    {
        private readonly ILancheRepository _lancheRepository;

        public LancheService(ILancheRepository lancheRepository) : base(lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public new IEnumerable<Lanche> FindAll()
        {
            return _lancheRepository.FindAll();
        }

        public new Lanche FindById(int Id)
        {
            return _lancheRepository.FindById(Id);
        }
    }
}
