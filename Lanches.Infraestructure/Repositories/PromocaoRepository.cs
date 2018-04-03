using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace Lanches.Infraestructure.Repositories
{
    public class PromocaoRepository : RepositoryBase<Promocao>, IPromocaoRepository
    {
        private List<Promocao> _listaPromocoes;

        public PromocaoRepository()
        {
            _listaPromocoes = new List<Promocao>
            {
                new Promocao
                {
                    Id = 1,
                    Nome = "Light",
                    PercentualDesconto = 0.1M,
                    Quantidade = 0
                }
            };
        }

        public new IEnumerable<Promocao> FindAll()
        {
            IEnumerable<Promocao> promocaos = _listaPromocoes;
            return promocaos;
        }

        public new Promocao FindById(int Id)
        {
            return _listaPromocoes.Find(t => t.Id == Id);
        }
    }
}
