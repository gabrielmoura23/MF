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
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadatro { get; set; }


        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            var fiscal = new ProdutoEstaAptoParaCadastroNoSistema();
            ResultadoValidacao = fiscal.Validar(this);
            return ResultadoValidacao.IsValid;
        }

    }
}
