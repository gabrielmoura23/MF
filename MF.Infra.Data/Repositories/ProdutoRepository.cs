using MF.Domain.Entities;
using MF.Domain.Interfaces.Repository;
using MF.Infra.Data.Context;
using System.Collections.Generic;

namespace MF.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto,MFContext>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            var b = 1;
            return base.Find(c => c.Descricao == nome);
        }
    }
}
