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
        }

        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }
        public int IdUnidade { get; set; }
        public int ValorUnitario { get; set; }
        public int EstoqueMinimo { get; set; }
        public int QtdEstoque { get; set; }
        public bool FlgAtivo { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadatro { get; set; }
        public System.DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        /*
        ValorUnitario
        unidade
        EstoqueMinimo
        QtdEstoque
        */

        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            var fiscal = new ProdutoEstaAptoParaCadastroNoSistema();
            ResultadoValidacao = fiscal.Validar(this);
            return ResultadoValidacao.IsValid;
        }

    }
}
