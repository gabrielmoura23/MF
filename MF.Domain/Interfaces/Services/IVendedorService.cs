using System.Collections.Generic;
using MF.Domain.Entities;
using MF.Domain.ValueObjects;

namespace MF.Domain.Interfaces.Services
{
    public interface IVendedorService : IServiceBase<Vendedor>
    {
        ValidationResult AdicionarVendedor(Vendedor model);
        IEnumerable<Vendedor> BuscarPorNome(string nome);
    }
}
