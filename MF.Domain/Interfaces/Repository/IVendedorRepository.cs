using MF.Domain.Entities;
using System.Collections.Generic;

namespace MF.Domain.Interfaces.Repository
{
    public interface IVendedorRepository : IRepositoryBase<Vendedor>
    {
        IEnumerable<Vendedor> BuscarPorNome(string nome);
    }
}
