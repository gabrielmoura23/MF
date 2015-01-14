using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class EmpresaContato
    {
        public EmpresaContato()
        {
        }

        public int IdEmpresaContato { get; set; }
        public int IdEmpresa { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Setor { get; set; }
        public string DddTelefone { get; set; }
        public string Telefone { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual Empresa Empresa { get; set; }
    }
}
