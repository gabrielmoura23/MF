using MF.Domain.Entities;
using MF.Domain.Specification.Produtos;
using MF.Domain.Validation.Base;

namespace MF.Domain.Validation.Produtos
{
    public class ProdutoEstaAptoParaCadastroNoSistema : FiscalBase<Produto>
    {
        public ProdutoEstaAptoParaCadastroNoSistema()
        {
        }
    }
}
