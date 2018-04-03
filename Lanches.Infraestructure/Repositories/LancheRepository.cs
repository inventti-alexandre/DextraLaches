using System.Collections.Generic;
using Lanches.Domain.Entities;
using Lanches.Domain.Interfaces.Repositories;

namespace Lanches.Infraestructure.Repositories
{
    public class LancheRepository : RepositoryBase<Lanche>, ILancheRepository
    {
        public List<Lanche> _listaLanches;

        public LancheRepository()
        {
            _listaLanches = new List<Lanche>
            {
                new Lanche()
                {
                    Id = 1,
                    Nome = "X-Bacon",
                    Ingredientes = new List<Ingrediente>()
                    {
                        new Ingrediente() {Id = 2, Nome = "Bacon", Valor = 2, Quantidade = 1},
                        new Ingrediente() {Id = 3, Nome = "Hambúrguer de Carne", Valor = 3, Quantidade = 1},
                        new Ingrediente() {Id = 5, Nome = "Queijo", Valor = 1.5M, Quantidade = 1}
                    }
                },
                new Lanche()
                {
                    Id = 2,
                    Nome = "X-Burger",
                    Ingredientes = new List<Ingrediente>()
                    {
                        new Ingrediente() {Id = 3, Nome = "Hambúrguer de Carne", Valor = 3, Quantidade = 1},
                        new Ingrediente() {Id = 5, Nome = "Queijo", Valor = 1.5M, Quantidade = 1}
                    }
                },
                new Lanche()
                {
                    Id = 3,
                    Nome = "X-Egg",
                    Ingredientes = new List<Ingrediente>()
                    {
                        new Ingrediente() {Id = 4, Nome = "Ovo", Valor = 0.8M, Quantidade = 1},
                        new Ingrediente() {Id = 3, Nome = "Hambúrguer de Carne", Valor = 3, Quantidade = 1},
                        new Ingrediente() {Id = 5, Nome = "Queijo", Valor = 1.5M, Quantidade = 1}
                    }
                },
                new Lanche()
                {
                    Id = 4,
                    Nome = "X-Bacon Egg",
                    Ingredientes = new List<Ingrediente>()
                    {
                        new Ingrediente() {Id = 4, Nome = "Ovo", Valor = 0.8M, Quantidade = 1},
                        new Ingrediente() {Id = 2, Nome = "Bacon", Valor = 2, Quantidade = 1},
                        new Ingrediente() {Id = 3, Nome = "Hambúrguer de Carne", Valor = 3, Quantidade = 1},
                        new Ingrediente() {Id = 5, Nome = "Queijo", Valor = 1.5M, Quantidade = 1}
                    }
                }
            };
        }

        public new IEnumerable<Lanche> FindAll()
        {
            IEnumerable<Lanche> lanches = _listaLanches;
            return lanches;
        }

        public new Lanche FindById(int Id)
        {
            return _listaLanches.Find(t => t.Id == Id);
        }
    }
}
