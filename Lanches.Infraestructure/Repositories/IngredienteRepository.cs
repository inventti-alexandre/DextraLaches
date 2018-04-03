using System.Collections.Generic;
using Lanches.Domain.Entities;
using Lanches.Infraestructure.Repositories;
using Lanches.Domain.Interfaces.Repositories;

namespace Lanches.Domain.Services
{
    public class IngredienteRepository : RepositoryBase<Ingrediente>, IIngredienteRepository
    {
        private List<Ingrediente> _lstaIngredientes;

        public IngredienteRepository()
        {
            _lstaIngredientes = new List<Ingrediente>
            {
                new Ingrediente()
                {
                    Id = 1,
                    Nome = "Alface",
                    Valor = 0.4M
                },
                new Ingrediente()
                {
                    Id = 2,
                    Nome = "Bacon",
                    Valor = 2
                },
                new Ingrediente()
                {
                    Id = 3,
                    Nome = "Hambúrguer de Carne",
                    Valor = 3
                },
                new Ingrediente()
                {
                    Id = 4,
                    Nome = "Ovo",
                    Valor = 0.8M
                },
                new Ingrediente()
                {
                    Id = 5,
                    Nome = "Queijo",
                    Valor = 1.5M
                }
            };
        }

        public new IEnumerable<Ingrediente> FindAll()
        {
            return _lstaIngredientes;
        }

        public new Ingrediente FindById(int Id)
        {
            return _lstaIngredientes.Find(t => t.Id == Id);
        }
    }
}
