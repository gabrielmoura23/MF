using MF.Domain.Validation.Produtos;
using MF.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Produto
    {
        public Produto()
        {
            this.DetalheVenda = new List<DetalheVenda>();
        }

        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public int IdTipoProduto { get; set; }
        public int IdTipoUnidade { get; set; }
        public int ValorUnitario { get; set; }
        public int QtdEstoqueMinimo { get; set; }
        public int QtdEstoque { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual TipoProduto TipoProduto { get; set; }
        public virtual TipoUnidade TipoUnidade { get; set; }
        public virtual ICollection<DetalheVenda> DetalheVenda { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            var fiscal = new ProdutoEstaAptoParaCadastroNoSistema();
            ResultadoValidacao = fiscal.Validar(this);
            return ResultadoValidacao.IsValid;
        }

    }
}
