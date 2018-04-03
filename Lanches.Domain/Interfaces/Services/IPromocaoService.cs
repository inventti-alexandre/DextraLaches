using Lanches.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanches.Domain.Interfaces.Services
{
    //Interface de Service para Promocao.
    public interface IPromocaoService : IServiceBase<Promocao>
    {
        new IEnumerable<Promocao> FindAll();
        new Promocao FindById(int Id);
    }
}
