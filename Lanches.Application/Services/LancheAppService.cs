using Lanches.Application.Interfaces;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace Lanches.Application.Services
{
    public class LancheAppService : AppServiceBase<Lanche>, ILancheAppService
    {
        private readonly ILancheService _lancheService;

        public LancheAppService(ILancheService lancheService) : base(lancheService)
        {
            _lancheService = lancheService;
        }

        public new IEnumerable<Lanche> FindAll()
        {
            var _listaLanches = new List<Lanche> { };
            var _lanche = _lancheService.FindAll();

            foreach (var item in _lanche)
            {
                item.Valor = CalculaPrecoLanche(item);
                _listaLanches.Add(item);
            }

            return _listaLanches;
        }

        public new Lanche FindById(int Id)
        {
            var _lanche = _lancheService.FindById(Id);

            _lanche.Valor = CalculaPrecoLanche(_lanche);

            return _lanche;
        }

        public decimal CalculaPrecoLanche(Lanche lanche)
        {
            decimal somaIngredientes = 0;

            foreach (var item in lanche.Ingredientes)
            {
                somaIngredientes = somaIngredientes + (item.Valor * item.Quantidade);
            }

            return somaIngredientes;
        }
    }
}
