using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lanches.Domain.Entities
{
    public class Ingrediente
    {
        // TODO: Colocar todas os Displays.

        [Display(Name = "Código do Ingrediente")]
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
    }
}
