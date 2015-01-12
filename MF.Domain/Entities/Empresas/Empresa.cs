using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class Empresa
    {
        public Empresa()
        {
        }

        public int IdEmpresa { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public bool FlgAtivo { get; set; }
        public DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }
    }
}
