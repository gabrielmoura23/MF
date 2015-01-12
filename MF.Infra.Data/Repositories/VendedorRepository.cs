using MF.Domain.Entities;
using MF.Domain.Interfaces.Repository;
using MF.Infra.Data.Context;
using System.Collections.Generic;

namespace MF.Infra.Data.Repositories
{
    public class VendedorRepository : RepositoryBase<Vendedor, MFContext>, IVendedorRepository
    {
        public IEnumerable<Vendedor> BuscarPorNome(string nome)
        {
            return base.Find(c => c.NomeCompleto == nome);
        }
    }
}
