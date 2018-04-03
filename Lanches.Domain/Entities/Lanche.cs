using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches.Domain.Entities
{
    public class Lanche
    {
        // TODO: Colocar todas os Displays.

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }

        public virtual IEnumerable<Ingrediente> Ingredientes { get; set; }
    }
}
