using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MF.Domain.Entities
{
    class Usuario
    {
        public Usuario()
        { }

        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool FlgPrivilegiado { get; set; }
        public bool FlgAtivo { get; set; }
        public DateTime DtCadastro { get; set; }
        public string UsuCadastro { get; set; }
        public DateTime DtAlteracao { get; set; }
        public string UsuAlteracao { get; set; }

    }
}
