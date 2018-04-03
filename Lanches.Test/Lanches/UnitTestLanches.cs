using Lanches.Application.Interfaces;
using Lanches.Application.Services;
using Lanches.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lanches.Test.Lanches
{
    [TestClass]
    public class UnitTestLanches
    {
        private readonly ILancheAppService _lancheAppService;

        public UnitTestLanches(ILancheAppService lancheAppService)
        {
            this._lancheAppService = lancheAppService;
        }

        [TestMethod]
        public void CalculaPrecoLanchePadrao()
        {
            //Arrange.
            Lanche lanche = _lancheAppService.FindById(1);
            decimal valorLanche = CalculaPrecoLanche(lanche);

            //Act.
            var preco = _lancheAppService.CalculaPrecoLanche(lanche);

            //Assert.
            Assert.IsTrue(preco == 0);

        }

        private decimal CalculaPrecoLanche(Lanche _lanche)
        {
            decimal somaIngredientes = 0;

            foreach (var item in _lanche.Ingredientes)
            {
                somaIngredientes = somaIngredientes + item.Valor;
            }

            return somaIngredientes;
        }
    }
}
