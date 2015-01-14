using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    public class UsuarioExterno
    {
        public UsuarioExterno()
        {
            this.UsuarioExternoEmpresa = new List<UsuarioExternoEmpresa>();
        }

        public int IdUsuarioExterno { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string EndNum { get; set; }
        public string Bairro { get; set; }
        public string IdEstado { get; set; }
        public int IdCidade { get; set; }
        public string Cep { get; set; }
        public string DddTelefone { get; set; }
        public string Telefone { get; set; }
        public string DddCelular { get; set; }
        public string Celular { get; set; }
        public string Setor { get; set; }
        public string Cargo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public Nullable<System.DateTime> DtAlteracaoSenha { get; set; }
        public Nullable<System.DateTime> DtUltimoLogin { get; set; }
        public System.DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public Nullable<System.DateTime> DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

        public virtual ICollection<UsuarioExternoEmpresa> UsuarioExternoEmpresa { get; set; }
        public virtual Estado Estado { get; set; }
        public virtual Cidade Cidade { get; set; }
    }
}
