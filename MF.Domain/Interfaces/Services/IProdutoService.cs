using System.Collections.Generic;
using MF.Domain.Entities;
using MF.Domain.ValueObjects;

namespace MF.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        ValidationResult AdicionarProduto(Produto model);
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
