using MF.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Vendedor
    {
        public Vendedor()
        {
        }

        public int IdVendedor { get; set; }
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadatro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public ValidationResult ResultadoValidacao { get; private set; }
        public bool IsValid()
        {
            return true;

            //var fiscal = new ProdutoEstaAptoParaCadastroNoSistema();
            //ResultadoValidacao = fiscal.Validar(this);
            //return ResultadoValidacao.IsValid;
        }
    }
}
