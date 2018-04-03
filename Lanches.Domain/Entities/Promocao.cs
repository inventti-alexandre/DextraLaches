using System.Collections.Generic;

namespace Lanches.Domain.Entities
{
    public class Promocao
    {
        // TODO: Colocar todas os Displays.

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal Valor { get; set; }

        public virtual IEnumerable<Ingrediente> Ingredientes { get; set; }
    }
}
